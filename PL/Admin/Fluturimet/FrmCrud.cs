using FlightManagement.Core.Data.Entities;
using FlightManagement.Core.Logic;
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

namespace FlightManagement.PL.Admin.Fluturimet.AddFlight
{
    public partial class FrmCrud : Form
    {
        public bool isLoaded = false;
        public FrmCrud()
        {
            InitializeComponent();
        }

        private void FrmCrud_Load(object sender, EventArgs e)
        {
            FillDataGridView();

            cbPlaneStatus.Items.Add("Aktiv");
            cbPlaneStatus.Items.Add("Jashtë Shërbimi");
            cbPlaneType.Items.AddRange(PlaneDeafults.planeTemplates.Keys.ToArray());
            cbPlaneStatus.SelectedIndex = -1;
            isLoaded = true;

            lblTitleData.Text = "✈️Avione te shtuar me: " + DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnSwitchPanelData_Click(object sender, EventArgs e)
        {
            btnSwitchPanelSeatMap.Visible = false;
            btnSwitchPanelData.Visible = true;

            pnlData.Visible = false;
            pnlSeatMap.Visible = true;
        }

        private void btnSwitchPanelSeatMap_Click(object sender, EventArgs e)
        {
            btnSwitchPanelData.Visible = false;
            btnSwitchPanelSeatMap.Visible = true;

            pnlData.Visible = true;
            pnlSeatMap.Visible = false;
        }

        private void cbPlaneType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoaded || cbPlaneType.SelectedIndex == -1) return;

            string selectedPlaneType = cbPlaneType.SelectedItem.ToString();
            if (PlaneDeafults.planeTemplates.TryGetValue(selectedPlaneType, out var plane))
            {
                txtSeatNr.Text = plane.SeatCount.ToString();
                txtMaxRange.Text = plane.RangeKm.ToString();
                cbPlaneStatus.SelectedItem = plane.Status;

                lblTitleSeatMap.Text = $"💺Paraqitja vizuale e avionit te selektuar: {selectedPlaneType}";

                pbSeatMap.Image = null;

                var imageFileName = selectedPlaneType + ".png";
                string imagePath = Path.Combine(Application.StartupPath, "Resources", "SeatMaps", imageFileName);

                if (File.Exists(imagePath))
                {
                    pbSeatMap.Image = Image.FromFile(imagePath);
                    pbSeatMap.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbSeatMap.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else
                {
                    pbSeatMap.Image = null;
                    MessageBox.Show("Harta për këtë avion nuk u gjet.");
                }

            }
        }

        public void btnClear_Click(object sender, EventArgs e)
        {
            cbPlaneType.SelectedIndex = -1;
            txtSeatNr.Text = string.Empty;
            txtMaxRange.Text = string.Empty;
            cbPlaneStatus.SelectedIndex = -1;
            pbSeatMap.Image = null;
            txtPlaneId.Text = string.Empty;
            txtPlaneRegistration.Text = string.Empty;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var newPlane = new Planes
                {
                    Model = cbPlaneType.SelectedItem?.ToString(),
                    PlaneId = int.Parse(txtPlaneId.Text),
                    Registration = txtPlaneRegistration.Text,
                    SeatCount = int.Parse(txtSeatNr.Text),
                    RangeKm = int.Parse(txtMaxRange.Text),
                    Status = cbPlaneStatus.SelectedItem?.ToString(),
                    CreatedDate = DateTime.Today
                };

                Program.PlanesManager.AddPlane(newPlane);
                MessageBox.Show("Avioni u shtua me sukses!");
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

            FillDataGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            FillDataGridView();
        }

        private void dgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FillDataGridView()
        {
            dgData.DataSource = null;
            dgData.DataSource = Program.PlanesManager.GetAll();

            dgData.Columns["Id"].Visible = false;
            dgData.Columns["UpdatedDate"].Visible = false;

            dgData.Columns["PlaneId"].HeaderText = "ID e Avionit";
            dgData.Columns["Model"].HeaderText = "Modeli";
            dgData.Columns["Registration"].HeaderText = "Regjistrimi";
            dgData.Columns["SeatCount"].HeaderText = "Vendesh";
            dgData.Columns["RangeKm"].HeaderText = "Rrezja (km)";
            dgData.Columns["Status"].HeaderText = "Statusi";
            dgData.Columns["HasClasses"].HeaderText = "Ka Klasa?";
            dgData.Columns["BuisnessFactor"].HeaderText = "Koef. Biznes";
            dgData.Columns["FirstClassFactor"].HeaderText = "Koef. First";
            dgData.Columns["CreatedDate"].HeaderText = "Data e Shtimit";
        }
    }
}
