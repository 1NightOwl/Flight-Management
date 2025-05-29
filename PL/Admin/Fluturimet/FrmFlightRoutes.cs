using FlightManagement.Core.Data.Entities;
using FlightManagement.Core.Logic;
using FlightManagement.Core.Logic.Managers;
using FlightManagement.Core.Templates;
using Microsoft.IdentityModel.Tokens;
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
using System.Xml.Linq;

namespace FlightManagement.PL.Admin.Fluturimet
{
    public partial class FrmFlightRoutes : Form
    {
        string[] Airports = RouteDeafults.Airports;
        private int selectedRouteDbId = -1;
        private int selectedPlaneId;
        public bool isLoaded = false;

        public FrmFlightRoutes()
        {
            InitializeComponent();
        }
        private void FrmFlightRoutes_Load(object sender, EventArgs e)
        {
            cbStatus.Items.Add("Aktiv");
            cbStatus.Items.Add("Jo Aktiv");

            cbPlaneType.Items.AddRange(PlaneDeafults.planeTemplates.Keys.ToArray());
            isLoaded = true;

            cbOrigin.Items.AddRange(Airports);
            cbDestination.Items.AddRange(Airports);

            cbDepartDay.Items.AddRange(RouteDeafults.DaysOfTheWeek);

            FillDataGridView();
            FillDataGridViewAvailablePlanes();
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
            if (!isLoaded) return;

            if (cbPlaneType.SelectedIndex == -1)
            {
                FillDataGridViewAvailablePlanes();
                UpdatePrices();
                return;
            }

            FillFilteredPlanes();
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
                numPrice.Text,
                lblPlaneClasses,
                lblEconomy,
                lblBusiness,
                lblFirstClass
            );
        }
        private void numPrice_TextChanged(object sender, EventArgs e)
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

            string selectedDestination = cbDestination.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedDestination)) return;

            cbOrigin.Items.Clear();

            foreach (var airport in RouteDeafults.Airports)
            {
                if (airport != selectedDestination)
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
            cbStatus.SelectedIndex = -1;
            cbDestination.SelectedIndex = -1;
            cbDepartDay.SelectedIndex = -1;

            numPrice.Text = string.Empty;
            txtPlaneId.Text = string.Empty;
            numPrice.Text = string.Empty;
            dtArrival.Value = DateTime.Now;
            dtDeparture.Value = DateTime.Now;

            txtPlaneId.ReadOnly = false;
            cbPlaneType.Enabled = true;
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            UpdatePrices();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedModel = cbPlaneType.SelectedItem?.ToString();
                if (!PlaneDeafults.planeTemplates.TryGetValue(selectedModel, out var template))
                {
                    MessageBox.Show("Modeli i avionit nuk u gjet.");
                    return;
                }

                if (selectedPlaneId <= 0)
                {
                    MessageBox.Show("Ju lutem, zgjidhni një avion nga lista përpara se të shtoni rrugën.");
                    return;
                }

                //if (HasConflict(txtPlaneId, cbDepartDay, dtDeparture, dtArrival, editingId))
                //{
                //    SetErr(dtpStart, "Ky avion ka një fluturim tjetër në këtë kohë.");
                //    return;
                //}


                var newRoute = new Route
                {
                    PlaneId = selectedPlaneId,
                    Departure = cbOrigin.Text,
                    Arrival = cbDestination.Text,
                    DepartureDay = cbDepartDay.Text,
                    StartTime = dtDeparture.Value.TimeOfDay,
                    Status = cbStatus.SelectedItem?.ToString(),
                    EndTime = dtArrival.Value.TimeOfDay,
                    Price = int.Parse(numPrice.Text),
                    CreatedDate = DateTime.Today
                };

                Program.RoutesManager.AddRoute(newRoute);
                MessageBox.Show("Rruga u shtua me sukses!");
                btnClear_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gabim gjatë shtimit: " + ex.Message);
            }
            FillDataGridView();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedRouteDbId == -1)
            {
                MessageBox.Show("Zgjidh një rruge për përditësim.");
                return;
            }

            try
            {

                //var selectedModel = cbPlaneType.SelectedItem?.ToString();
                //if (!PlaneDeafults.planeTemplates.TryGetValue(selectedModel, out var template))
                //{
                //    MessageBox.Show("Modeli i avionit nuk u gjet.");
                //    return;
                //}

                var updatedRoute = new Route
                {
                    PlaneId = int.Parse(txtPlaneId.Text),
                    Departure = cbOrigin.Text,
                    Arrival = cbDestination.Text,
                    DepartureDay = cbDepartDay.Text,
                    StartTime = dtDeparture.Value.TimeOfDay,
                    Status = cbStatus.SelectedItem?.ToString(),
                    EndTime = dtArrival.Value.TimeOfDay,
                    Price = int.Parse(numPrice.Text),
                    UpdatedDate = DateTime.Now
                };

                Program.RoutesManager.UpdateRoute(selectedRouteDbId, updatedRoute);
                MessageBox.Show("Rruga u përditësua me sukses!");
                btnClear_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gabim gjatë përditësimit: " + ex.Message);
            }
            FillDataGridView();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRouteDbId == -1)
            {
                MessageBox.Show("Zgjidh një rruge për fshirje.");
                return;
            }

            var confirm = MessageBox.Show("Jeni i sigurt që doni të fshini këtë rruge?", "Konfirmim", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                Program.RoutesManager.DeleteRoute(selectedRouteDbId);
                MessageBox.Show("Rruga u fshi me sukses!");
                btnClear_Click(null, null);
                FillDataGridView();
            }
            txtPlaneId.Enabled = true;
            cbPlaneType.Enabled = true;
        }
        private void FillDataGridView()
        {
            dgPlaneRouteList.AutoGenerateColumns = true;
            dgPlaneRouteList.DataSource = null;
            dgPlaneRouteList.DataSource = Program.RoutesManager.GetAllRoutes();
            dgPlaneRouteList.Columns["Plane"].Visible = false;
            dgPlaneRouteList.Columns["Id"].Visible = false;

            dgPlaneRouteList.Columns["PlaneId"].HeaderText = "ID e Avionit";
            dgPlaneRouteList.Columns["Departure"].HeaderText = "Nisja";
            dgPlaneRouteList.Columns["Arrival"].HeaderText = "Mbërritja";
            dgPlaneRouteList.Columns["DepartureDay"].HeaderText = "Dita";
            dgPlaneRouteList.Columns["StartTime"].HeaderText = "Ora Nisjes"; 
            dgPlaneRouteList.Columns["EndTime"].HeaderText = "Ora Mbërritjes";

            dgPlaneRouteList.Columns["StartTime"].DefaultCellStyle.Format = "hh\\:mm";
            dgPlaneRouteList.Columns["EndTime"].DefaultCellStyle.Format = "hh\\:mm";

            dgPlaneRouteList.Columns["Status"].HeaderText = "Statusi";
            dgPlaneRouteList.Columns["Price"].HeaderText = "Çmimi";
            dgPlaneRouteList.Columns["CreatedDate"].HeaderText = "Data Shtimit";
            dgPlaneRouteList.Columns["UpdatedDate"].HeaderText = "Data Përditësimit";
            dgPlaneRouteList.Columns["CreatedDate"].DefaultCellStyle.Format = "MM/dd/yyyy";
            dgPlaneRouteList.Columns["UpdatedDate"].DefaultCellStyle.Format = "MM/dd/yyyy";
            dgPlaneRouteList.Columns["UpdatedDate"].DefaultCellStyle.NullValue = "—";
        }
        private void FillDataGridViewAvailablePlanes()
        {
            dgAviablePlanes.AutoGenerateColumns = true;
            dgAviablePlanes.DataSource = null;
            dgAviablePlanes.DataSource = Program.PlanesManager.GetAll();
            dgAviablePlanes.DataSource = Program.PlanesManager
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

            foreach (DataGridViewColumn col in dgAviablePlanes.Columns)
            {
                col.Visible = visibleColumns.Contains(col.Name);
            }

            dgAviablePlanes.Columns["Id"].Visible = false;
            dgAviablePlanes.Columns["PlaneId"].HeaderText = "ID e Avionit";
            dgAviablePlanes.Columns["Model"].HeaderText = "Modeli i Avionit";
            dgAviablePlanes.Columns["SeatCount"].HeaderText = "Numri i Vendeve";
            dgAviablePlanes.Columns["HasClasses"].HeaderText = "Ka Klasa?";
            dgAviablePlanes.Columns["BuisnessFactor"].HeaderText = "Koef. Biznes";
            dgAviablePlanes.Columns["FirstClassFactor"].HeaderText = "Koef. First";
        }
        private void dgPlaneRouteList_CellClick(object sender, DataGridViewCellEventArgs e)
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
                btnAdd.Enabled = false;
                cbPlaneType.Enabled = false;
                txtPlaneId.Enabled = false;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;

                if (e.RowIndex < 0) return;
                    var row = dgPlaneRouteList.Rows[e.RowIndex];

                    selectedRouteDbId = Convert.ToInt32(row.Cells["Id"].Value);
                    selectedPlaneId = Convert.ToInt32(row.Cells["PlaneId"].Value);

                var modelName = Program.PlanesManager
                                        .GetAll()
                                        .Where(p => p.Id == selectedPlaneId)
                                        .Select(p => p.Model)
                                        .FirstOrDefault();

                    cbPlaneType.Text = modelName;
                    txtPlaneId.Text = row.Cells["PlaneId"].Value.ToString();
                    cbOrigin.Text = row.Cells["Departure"].Value.ToString();
                    cbDestination.Text = row.Cells["Arrival"].Value.ToString();
                    cbDepartDay.Text = row.Cells["DepartureDay"].Value.ToString();
                    dtDeparture.Value = DateTime.Today.Add((TimeSpan)row.Cells["StartTime"].Value);
                    dtArrival.Value = DateTime.Today.Add((TimeSpan)row.Cells["EndTime"].Value);
                    cbStatus.SelectedItem = row.Cells["Status"].Value?.ToString() ?? "Aktiv";
                    numPrice.Text = row.Cells["Price"].Value.ToString();

            }
            else
            {

            }
        }
        private void dgAviablePlanes_CellClick(object sender, DataGridViewCellEventArgs e)
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
                cbPlaneType.Enabled = false;
                txtPlaneId.Enabled = false;

                if (e.RowIndex < 0)return;

                    var row = dgAviablePlanes.Rows[e.RowIndex];
                    selectedPlaneId = Convert.ToInt32(row.Cells["Id"].Value);

                    txtPlaneId.Text = row.Cells["PlaneId"].Value.ToString();
                    cbPlaneType.Text = row.Cells["Model"].Value.ToString();
                    cbStatus.SelectedItem = "Aktiv";
            }
            else
            {

            }
        }
        private void FillFilteredPlanes()
        {

            string selectedModel = cbPlaneType.Text;

            var filteredPlanes = Program.PlanesManager
                    .GetAll()
                    .Where(p => p.Status == "Aktiv" && p.Model == selectedModel)
                    .ToList();

            dgAviablePlanes.DataSource = null;
            dgAviablePlanes.DataSource = filteredPlanes;

            var visibleColumns = new List<string>
             {
                 "PlaneId",
                 "Model",
                 "SeatCount",
                 "HasClasses",
                 "BuisnessFactor",
                 "FirstClassFactor"
             };

            foreach (DataGridViewColumn col in dgAviablePlanes.Columns)
                col.Visible = visibleColumns.Contains(col.Name);

            dgAviablePlanes.Columns["PlaneId"].HeaderText = "ID e Avionit";
            dgAviablePlanes.Columns["Model"].HeaderText = "Modeli i Avionit";
            dgAviablePlanes.Columns["SeatCount"].HeaderText = "Numri i Vendeve";
            dgAviablePlanes.Columns["HasClasses"].HeaderText = "Ka Klasa?";
            dgAviablePlanes.Columns["BuisnessFactor"].HeaderText = "Koef. Biznes";
            dgAviablePlanes.Columns["FirstClassFactor"].HeaderText = "Koef. First";
        }

        //bool HasConflict(int planeId, string day, TimeSpan start, TimeSpan end, int? editingId = null)
        //{
        //    return Program.DbContext.Routes.Any(r =>
        //        r.PlaneId == planeId &&
        //        r.DepartureDay == day &&
        //        r.Id != editingId &&                            // ignore the route we’re editing
        //        r.StartTime < end && start < r.EndTime);        // classic overlap test
        //}
    }
}