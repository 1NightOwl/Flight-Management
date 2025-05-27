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
        }
        private void lblRegister_Click(object sender, EventArgs e)
        {
            pnlLogIn.Visible = false;
            pnlRegister.Visible = true;
            txtPassword.Clear();
            txtEmUsr.Clear();
            rbTermsAndConds.Checked = false;
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

        private void btnLogIn_Click(object sender, EventArgs e)
        {
                string userEmail = txtEmUsr.Text.Trim();
                string password = txtPassword.Text;
                try
                {
                    var user = new UsersManager();
                    var logIn = user.Login(userEmail, password);
                    Session.StartSession(logIn);


                    if (logIn.Role == Constants.RoleAdmin) { 

                        FrmPreviewAdmin admin = new FrmPreviewAdmin();
                         admin.Show();
                         this.Hide();
                    }
                    else
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
            if(pnlLogIn.Visible = true)
            this.AcceptButton = btnLogin;

            else if (pnlRegister.Visible = true)
                this.AcceptButton = btnRegister;
        }
    }
}
