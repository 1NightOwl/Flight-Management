using FlightManagement.Core;
using FlightManagement.PL.Start.Log_in;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightManagement.PL.Admin
{
    public partial class FrmAdminAccount : Form
    {
        public FrmAdminAccount()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string newUsername = txtUsername.Text.Trim();
            string newEmail = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(newUsername))
            {
                MessageBox.Show("Emri i përdoruesit nuk mund të jetë bosh.", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!newEmail.Contains("@") || !newEmail.Contains("."))
            {
                MessageBox.Show("Shkruani një email të vlefshëm.", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = Program.DbContext.Users.Find(Session.CurrentUser.Id);
            if (user == null)
            {
                MessageBox.Show("Përdoruesi nuk u gjet.", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            user.Username = newUsername;
            user.Email = newEmail;
            Program.DbContext.SaveChanges();

            MessageBox.Show("Të dhënat u përditësuan me sukses!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowUserDetails();
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            string oldPwd = txtOldPassword.Text;
            string newPwd = txtNewPassword.Text;
            string confirmPwd = txtRepeat.Text;

            if (string.IsNullOrEmpty(oldPwd)
             || string.IsNullOrEmpty(newPwd)
             || string.IsNullOrEmpty(confirmPwd))
            {
                MessageBox.Show(
                    "Plotësoni të gjitha fushat e fjalëkalimit.",
                    "Gabim",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            if (newPwd != confirmPwd)
            {
                MessageBox.Show(
                    "Fjalëkalimet e reja nuk përputhen.",
                    "Gabim",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            var user = Program.DbContext.Users
                          .Where(u => u.Id == Session.CurrentUser.Id)
                          .FirstOrDefault();

            if (user == null)
            {
                MessageBox.Show(
                    "Përdoruesi nuk u gjet.",
                    "Gabim",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            if (oldPwd != user.Password)
            {
                MessageBox.Show(
                    "Fjalëkalimi i vjetër nuk është i saktë.",
                    "Gabim",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            user.Password = newPwd;
            Program.DbContext.SaveChanges();

            MessageBox.Show(
                "Fjalëkalimi u ndryshua me sukses!",
                "Sukses",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            txtOldPassword.Text = "";
            txtNewPassword.Text = "";
            txtRepeat.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
              "Jeni të sigurt që doni të fshini llogarinë tuaj? Kjo veprim do të fshijë të gjitha rezervimet dhe të dhënat nga sistemi.",
              "Konfirmo fshirjen e llogarisë",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Warning
         );
            if (confirm == DialogResult.Yes)
            {
                var user = Program.DbContext.Users.Find(Session.CurrentUser.Id);
                if (user != null)
                {
                    if (user.Role == "Admin")
                    {
                        int totalAdmins = Program.DbContext.Users.Count(u => u.Role == "Admin");
                        if (totalAdmins <= 1)
                        {
                            MessageBox.Show(
                                "Nuk mund të fshini llogarinë pasi jeni administratori i vetëm në sistem.",
                                "Veprim i pamundur",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                            return;
                        }
                    }

                    var tickets = Program.DbContext.Biletat.Where(b => b.UserId == user.Id).ToList();
                    Program.DbContext.Biletat.RemoveRange(tickets);

                    Program.DbContext.Users.Remove(user);
                    Program.DbContext.SaveChanges();

                    MessageBox.Show("Llogaria juaj është fshirë. Faleminderit!", "Fshirje e kryer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var frmLogin = new FrmLogIn();
                    frmLogin.Show();
                    Session.StopSession(user);
                    this.Close();
                }
            }
        }

        private void FrmAdminAccount_Load(object sender, EventArgs e)
        {
            ShowUserDetails();
        }
        private void ShowUserDetails()
        {
            txtUsername.Text = Session.CurrentUser.Username;
            txtEmail.Text = Session.CurrentUser.Email;
        }

        private void btnShowOld_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.PasswordChar == '*')
            {
                txtOldPassword.PasswordChar = '\0';

            }
            else
            {
                txtOldPassword.PasswordChar = '*';
            }
        }

        private void btnShowNew_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.PasswordChar == '*')
            {
                txtNewPassword.PasswordChar = '\0';

            }
            else
            {
                txtNewPassword.PasswordChar = '*';
            }
        }

        private void btnShowRepeat_Click(object sender, EventArgs e)
        {
            if (txtRepeat.PasswordChar == '*')
            {
                txtRepeat.PasswordChar = '\0';

            }
            else
            {
                txtRepeat.PasswordChar = '*';

            }
        }
    }
}
