using FlightManagement.Core;
using FlightManagement.PL.Admin;
using FlightManagement.PL.Admin.Biletat;
using FlightManagement.PL.Admin.Fluturimet;
using FlightManagement.PL.Admin.Fluturimet.AddFlight;
using FlightManagement.PL.Admin.Perdoruesit;
using FlightManagement.PL.Start.Log_in;
using FlightManagement.PL.User.Flights;
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
    public partial class FrmPreviewAdmin : Form
    {
        private bool showPannelFlights = false;
        private bool showPannelTickets = false;
        private bool showPannelUsers = false;
        public FrmPreviewAdmin()
        {
            InitializeComponent();

            pnlControls.SuspendLayout();
            pnlControls.Visible = false;
            if (Session.CurrentUser != null)
                LoadPanels(new FrmCrud());
            pnlControls.ResumeLayout();
            pnlControls.Visible = true;
        }
        private void togglePannels()
        {
            if (showPannelFlights)
            {
                pnlFlights.Height = 138;
            }
            else
            {
                pnlFlights.Height = 0;
            }
        }

        private void btnFlights_Click(object sender, EventArgs e)
        {
            showPannelTickets = false;
            showPannelUsers = false;

            showPannelFlights = !showPannelFlights;
            togglePannels();
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            showPannelFlights = false;
            LoadPanels(new FrmBiletat());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            showPannelFlights = false;
            LoadPanels(new FrmActiveUsers());
        }


        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to continue?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                FrmLogIn login = new FrmLogIn();
                this.Hide();
                login.Show();
            }
            else
            {

            }
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            LoadPanels(new FrmCrud());
        }
        private void btnAssignRoute_Click(object sender, EventArgs e)
        {
            LoadPanels(new FrmFlightRoutes());
        }
        private void btnActiveFlights_Click(object sender, EventArgs e)
        {
            LoadPanels(new FrmActiveFlights());
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
        private void FrmPreviewAdmin_Load(object sender, EventArgs e)
        {
            if (Session.CurrentUser != null)
            {
                lblUsername.Text = $"{Session.CurrentUser.Username}";
                lblEmail.Text = $"{Session.CurrentUser.Email}";
            }
        }

        private void btnAdminAccount_Click(object sender, EventArgs e)
        {
            showPannelFlights = false;
            LoadPanels(new FrmAdminAccount());
        }
    }
}
