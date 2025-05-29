using FlightManagement.Core;
using FlightManagement.PL.Start.Log_in;
using FlightManagement.PL.User;
using FlightManagement.PL.User.Flights;
using FlightManagement.PL.User.Udhetimet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightManagement.PL.Preview
{
    public partial class FrmPreviewUser : Form
    {
        public FrmPreviewUser()
        {
            InitializeComponent();

            pnlControls.SuspendLayout();
            pnlControls.Visible = false;
            if (Session.CurrentUser != null)
                LoadPanels(new FrmBrowseFlights());
            pnlControls.ResumeLayout();
            pnlControls.Visible = true;
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
        private void LoadPanels(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlControls.Controls.Clear();
            pnlControls.Controls.Add(form);
            form.Show();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void FrmPreviewUser_Load(object sender, EventArgs e)
        {
            if (Session.CurrentUser != null)
            {
                lblUsername.Text = $"{Session.CurrentUser.Username}";
                lblEmail.Text = $"{Session.CurrentUser.Email}";
            }
        }

        private void btnFlights_Click(object sender, EventArgs e)
        {
            LoadPanels(new FrmBrowseFlights());
        }

        private void btnMyTrips_Click(object sender, EventArgs e)
        {
            LoadPanels(new FrmMyTickets());
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            LoadPanels(new FrmAccount());
        }
    }
}
