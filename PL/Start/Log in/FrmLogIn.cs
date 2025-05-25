using FlightManagement.Core;
using FlightManagement.Core.Common;
using FlightManagement.Core.Logic.Managers;
using FlightManagement.PL.Preview;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightManagement.PL.Start.Log_in
{
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();

            cbSelector.Items.Add("Admin");
            cbSelector.Items.Add("User");
        }
        private void lblRegister_Click(object sender, EventArgs e)
        {
            pnlLogIn.Visible = false;
            pnlRegister.Visible = true;
            txtPassword.Clear();
            txtEmUsr.Clear();
            rbTermsAndConds.Checked = false;
            cbSelector.SelectedIndex = -1;
        }

        private void pnlRegister_Click(object sender, EventArgs e)
        {
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            pnlLogIn.Visible = true;
            pnlRegister.Visible = false;
            txtUsername1.Clear();
            txtPassword1.Clear();
            txtEmail1.Clear();
            cbSelector.SelectedIndex = -1;
        }

        private void btnShow1_Click(object sender, EventArgs e)
        {
            if (txtPassword1.PasswordChar == '*')
            {
                txtPassword1.PasswordChar = '\0';

            }
            else
            {
                txtPassword1.PasswordChar = '*';

            }
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';

            }
            else
            {
                txtPassword.PasswordChar = '*';

            }
        }

        private void rbTermsAndConds_Click(object sender, EventArgs e)
        {
        }

        private void rbTermsAndConds_CheckedChanged(object sender, EventArgs e)
        {
            btnRegister.Enabled = rbTermsAndConds.Checked;
        }

        private void cbSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = cbSelector.SelectedIndex != -1;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string selectedRole = cbSelector.SelectedItem.ToString();

            if (selectedRole == Constants.RoleAdmin)
            {
                //FrmPreviewAdmin admin = new FrmPreviewAdmin();
                //admin.Show();
                //this.Hide();

                string userEmail = txtEmUsr.Text.Trim();
                string password = txtPassword.Text;
                try
                {
                    var user = new UsersManager();
                    var logIn = user.Login(userEmail, password);

                    Core.Session.StartSession(logIn);

                    if (Session.CurrentUser.Role == "Admin") { 

                        FrmPreviewAdmin admin = new FrmPreviewAdmin();
                         admin.Show();
                         this.Hide();
                    }
                    else if (Session.CurrentUser.Role == "User")
                    {
                        FrmPreviewUser userForm = new FrmPreviewUser();
                        userForm.Show();
                        this.Hide();
                    }
                }
                catch (FlightManagementException ex)
                {
                    MessageBox.Show(ex.Message, "Gabim në regjistrim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (selectedRole == Constants.RoleUser)
            {
                FrmPreviewUser user = new FrmPreviewUser();
                user.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a valid role.");
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername1.Text.Trim();
            string email = txtEmail1.Text.Trim();
            string password = txtPassword1.Text;

            try
            {
                var mgr = new UsersManager();
                mgr.RegisterUser(username, email, password);

                MessageBox.Show(
                              "Regjistrimi u krye me sukses!",
                              "Sukses",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information
                );
                txtUsername1.Clear();
                txtPassword1.Clear();
                txtEmail1.Clear();
                cbSelector.SelectedIndex = -1;
                pnlLogIn.Visible = true;
                pnlRegister.Visible = false;
            }
            catch (FlightManagementException ex)
            {
                MessageBox.Show(ex.Message, "Gabim në regjistrim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
        }
    }
}
