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

        private void btnLogIn_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.DarkCyan;
        }

        private void lbRegister_Click(object sender, EventArgs e)
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
            btnLogIn.Enabled = cbSelector.SelectedIndex != -1;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string selectedRole = cbSelector.SelectedItem.ToString();

            if (selectedRole == "Admin")
            {
                FrmPreviewAdmin admin = new FrmPreviewAdmin();
                admin.Show();
                this.Hide();
            }
            else if (selectedRole == "User")
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
            pnlLogIn.Visible = true;
            pnlRegister.Visible = false;
            txtUsername1.Clear();
            txtPassword1.Clear();
            txtEmail1.Clear();
            cbSelector.SelectedIndex = -1;
        }
    }
}
