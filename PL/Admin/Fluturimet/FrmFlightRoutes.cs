using FlightManagement.Core.Logic;
using FlightManagement.Core.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightManagement.PL.Admin.Fluturimet
{
    public partial class FrmFlightRoutes : Form
    {
        string[] Airports = RouteDeafults.Airports;

        public bool isLoaded = false;


        public FrmFlightRoutes()
        {
            InitializeComponent();
        }
        private void FrmFlightRoutes_Load(object sender, EventArgs e)
        {
            cbPlaneType.Items.AddRange(PlaneDeafults.planeTemplates.Keys.ToArray());
            isLoaded = true;

            cbOrigin.Items.AddRange(Airports);
            cbDestination.Items.AddRange(Airports);

            cbDepartDay.Items.AddRange(RouteDeafults.DaysOfTheWeek);
        }

        private void btnSwitchPanelInput_Click(object sender, EventArgs e)
        {
            pnlPlaneClasses.Visible = false;
            pnlRouteInput.Visible = false;
            pnlRouteList.Visible = true;
            pnlRouteInput.Refresh();

            btnSwitchPanelInput.Visible = false;
            btnSwitchPanelList.Visible = true;
        }

        private void btnSwitchPanelList_Click(object sender, EventArgs e)
        {
            pnlPlaneClasses.Visible = false;
            pnlRouteList.Visible = false;
            pnlRouteInput.Visible = true;
            pnlRouteList.Refresh();

            btnSwitchPanelList.Visible = false;
            btnSwitchPanelInput.Visible = true;
        }
        private void btnShowClasses_Click(object sender, EventArgs e)
        {
            pnlRouteList.Visible = false;
            pnlRouteInput.Visible = false;
            pnlPlaneClasses.Visible = true;
            pnlRouteList.Refresh();
        }


        private void cbPlaneType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePrices();
        }

        public void UpdatePrices()
        {
            if (cbPlaneType.SelectedIndex == -1)
            {
                lblPlaneClasses.Text = "🎫 Klasat e avionit:";
                lblEconomy.Text = "💺 Economy: 0€";
                lblBusiness.Text = "";
                lblFirstClass.Text = "";
                lblBusiness.Visible = false;
                lblFirstClass.Visible = false;
                return;
            }
            string selectedPlaneType = cbPlaneType.SelectedItem.ToString();
            
            ClassPriceManager.UpdateClassPrice(
                selectedPlaneType,
                txtPrice.Text,
                lblPlaneClasses,
                lblEconomy,
                lblBusiness,
                lblFirstClass
            );
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            UpdatePrices();
        }

        private void cbOrigin_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedDeparture = cbOrigin.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedDeparture)) return;

            cbDestination.Items.Clear();

            foreach (var airport in RouteDeafults.Airports)
            {
                if (airport != selectedDeparture)
                {
                    cbDestination.Items.Add(airport);
                }
            }

            cbDestination.SelectedIndex = -1;
        }

        private void cbDestination_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedDeparture = cbDestination.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedDeparture)) return;

            cbOrigin.Items.Clear();

            foreach (var airport in RouteDeafults.Airports)
            {
                if (airport != selectedDeparture)
                {
                    cbOrigin.Items.Add(airport);
                }
            }

            cbOrigin.SelectedIndex = -1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbPlaneType.SelectedIndex = -1;
            cbOrigin.SelectedIndex = -1;
            cbOrigin.Text = "";

            cbDestination.SelectedIndex = -1;
            cbDepartDay.SelectedIndex = -1;

            txtPrice.Text = string.Empty;
            txtPlaneId.Text = string.Empty;
            txtPrice.Text = string.Empty;
            dtArrival.Value = DateTime.Now;
            dtDeparture.Value = DateTime.Now;

            UpdatePrices();
        }   
    }
}
