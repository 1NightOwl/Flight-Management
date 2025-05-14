using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightManagement.PL.Start.Log_in;

namespace FlightManagement.PL.Preview
{
    public partial class FrmPreviewUser : Form
    {
        public FrmPreviewUser()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
             "Do you want to continue?",
             "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {

                this.Hide();
                FrmLogIn login = new FrmLogIn();
                login.Show();
            }
            else
            {

            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }
    }
}
