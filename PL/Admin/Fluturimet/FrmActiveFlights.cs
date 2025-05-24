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
    }
}
