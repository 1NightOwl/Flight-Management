using FlightManagement.Core.Data.Entities;
using FontAwesome.Sharp;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightManagement.PL.Admin.Fluturimet
{
    public partial class FrmActiveFlights : Form
    {
        private int selectedPlaneId;
        public FrmActiveFlights()
        {
            InitializeComponent();
        }

        private void btnActivePlaneSwtich_Click(object sender, EventArgs e)
        {
            pnlRouteList.Visible = false;
            pnlActivePlanes.Visible = true;

            btnActivePlaneSwtich.Visible = false;
            btnRouteSwitch.Visible = true;

            btnRouteSwitch.Enabled = false;
        }
        private void btnRouteSwitch_Click(object sender, EventArgs e)
        {
            pnlActivePlanes.Visible = false;
            pnlRouteList.Visible = true;

            btnRouteSwitch.Visible = false;
            btnActivePlaneSwtich.Visible = true;
        }
        private void FrmActiveFlights_Load(object sender, EventArgs e)
        {
            FillDataGridViewAvailablePlanes();
        }
        private void FillDataGridViewAvailablePlanes()
        {
            dgActivePlanes.AutoGenerateColumns = true;
            dgActivePlanes.DataSource = null;
            dgActivePlanes.DataSource = Program.PlanesManager.GetAll();
            dgActivePlanes.DataSource = Program.PlanesManager
                                         .GetAll()
                                         .Where(p => p.Status == "Aktiv")
                                         .ToList();

            var visibleColumns = new List<string>
                    {
                         "PlaneId",
                         "Model",
                         "SeatCount",
                         "HasClasses",
                         "BuisnessFactor",
                         "FirstClassFactor"
                     };

            foreach (DataGridViewColumn col in dgActivePlanes.Columns)
            {
                col.Visible = visibleColumns.Contains(col.Name);
            }

            dgActivePlanes.Columns["Id"].Visible = false;
            dgActivePlanes.Columns["PlaneId"].HeaderText = "ID e Avionit";
            dgActivePlanes.Columns["Model"].HeaderText = "Modeli i Avionit";
            dgActivePlanes.Columns["SeatCount"].HeaderText = "Numri i Vendeve";
            dgActivePlanes.Columns["HasClasses"].HeaderText = "Ka Klasa?";
            dgActivePlanes.Columns["BuisnessFactor"].HeaderText = "Koef. Biznes";
            dgActivePlanes.Columns["FirstClassFactor"].HeaderText = "Koef. First";
        }
        private int GetPlaneIdFromRow(int rowIndex)
        {
            return Convert.ToInt32(dgActivePlanes.Rows[rowIndex].Cells["Id"].Value);
        }
        private void ShowRoutesForPlane(int planeId)
        {
            btnRouteSwitch.Enabled = true;

            var routes = Program.RoutesManager
                                .GetAllRoutes()
                                .Where(r => r.Status == "Aktiv" && r.PlaneId == planeId)
                                .ToList();

            BindRoutesGrid(routes);
        }
        private void BindRoutesGrid(List<Route> routes)
        {
            dgSelectedPlaneRoute.AutoGenerateColumns = true;
            dgSelectedPlaneRoute.DataSource = routes;

            var cols = new[]
            {
                "Arrival",
                "CreatedDate",
                "Departure",
                "DepartureDay",
                "EndTime",
                "PlaneId",
                "Price",
                "StartTime",
                "Status"
            };

            foreach (DataGridViewColumn c in dgSelectedPlaneRoute.Columns)
                c.Visible = cols.Contains(c.Name);

            dgSelectedPlaneRoute.Columns["PlaneId"].HeaderText = "ID e Avionit";
            dgSelectedPlaneRoute.Columns["Departure"].HeaderText = "Nisja";
            dgSelectedPlaneRoute.Columns["Arrival"].HeaderText = "Mbërritja";
            dgSelectedPlaneRoute.Columns["DepartureDay"].HeaderText = "Dita";
            dgSelectedPlaneRoute.Columns["StartTime"].HeaderText = "Ora Nisjes";
            dgSelectedPlaneRoute.Columns["EndTime"].HeaderText = "Ora Mbërritjes";
            dgSelectedPlaneRoute.Columns["StartTime"].DefaultCellStyle.Format = "hh\\:mm";
            dgSelectedPlaneRoute.Columns["EndTime"].DefaultCellStyle.Format = "hh\\:mm";
            dgSelectedPlaneRoute.Columns["Status"].HeaderText = "Statusi";
            dgSelectedPlaneRoute.Columns["Price"].HeaderText = "Çmimi";
            dgSelectedPlaneRoute.Columns["CreatedDate"].HeaderText = "Data Shtimit";
        }
        private void dgActivePlanes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Kontrollim nese rrjeshti qe admini ka shtyper eshte ai qe deshiron, 
            //dhe gjithashtu si mase brojtese kunder klikimit pa qellim mbi cell dhe fshirja e te dhenave te meparshme
            DialogResult result = MessageBox.Show(
                "Deshiron te marresh te dhenat e ketij avioni?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                if (e.RowIndex < 0) return;

                btnRouteSwitch.Enabled = true;

                int planeId = GetPlaneIdFromRow(e.RowIndex);
                ShowRoutesForPlane(planeId);
            }
            else
            {

            }
        }
    }
}
