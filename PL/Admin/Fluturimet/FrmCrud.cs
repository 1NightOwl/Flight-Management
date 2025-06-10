using FlightManagement.Core;
using FlightManagement.Core.Common;
using FlightManagement.Core.Data.Entities;
using FlightManagement.Core.Logic;
using FlightManagement.PL.Start.Log_in;
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
        private int selectedPlaneDbId = -1;

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
                numSeatNr.Text = plane.SeatCount.ToString();
                numMaxRange.Text = plane.RangeKm.ToString();
                cbPlaneStatus.SelectedItem = plane.Status;

                lblTitleSeatMap.Text = $"💺Paraqitja vizuale e avionit te selektuar: {selectedPlaneType}";


                //Heqja e imazhit te vendosur
                pbSeatMap.Image = null;
                //marrja e emrit te imazhit qe do te vendoset per avionin e ri
                var imageFileName = selectedPlaneType + ".png";
                string imagePath = Path.Combine(Application.StartupPath, "Resources", "SeatMaps", imageFileName);

                //kontrollimi nese imazhi ekziston ose jo dhe vendosja e sakte e saje ne picture box
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
            //Pastrimi i te gjithe fushave
            cbPlaneType.SelectedIndex = -1;
            numSeatNr.ResetText();
            numMaxRange.ResetText();
            cbPlaneStatus.SelectedIndex = -1;
            pbSeatMap.Image = null;
            txtPlaneId.Text = string.Empty;
            txtPlaneRegistration.Text = string.Empty;

            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbPlaneType.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Zgjidhni tipin e avionit (Model).",
                    "Gabim në përzgjedhje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                cbPlaneType.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPlaneId.Text)
             || !int.TryParse(txtPlaneId.Text, out int parsedPlaneId))
            {
                MessageBox.Show(
                    "Shkruani një ID (numër) valide për avionin.",
                    "Gabim në ID",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtPlaneId.Focus();
                return;
            }

            string registration = txtPlaneRegistration.Text.Trim();
            if (string.IsNullOrWhiteSpace(registration))
            {
                MessageBox.Show(
                    "Shkruani regjistrimin e avionit (Registration).",
                    "Gabim në Regjistrim",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtPlaneRegistration.Focus();
                return;
            }

            if (numSeatNr.Value <= 0)
            {
                MessageBox.Show(
                    "Numri i vendeve (SeatCount) duhet të jetë më i madh se zero.",
                    "Gabim në SeatCount",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                numSeatNr.Focus();
                return;
            }

            if (numMaxRange.Value <= 0)
            {
                MessageBox.Show(
                    "Rrezja e avionit (RangeKm) duhet të jetë më e madhe se zero.",
                    "Gabim në RangeKm",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                numMaxRange.Focus();
                return;
            }

            if (cbPlaneStatus.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Zgjidhni statusin e avionit (Aktiv / Jashtë Shërbimi).",
                    "Gabim në Status",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                cbPlaneStatus.Focus();
                return;
            }
            try
            {
                //Marrja e modelit te avionit
                string selectedModel = cbPlaneType.SelectedItem?.ToString();
                //Dhe kontrollimi nese ai ndodhet ne templatein e krijuar per avionat tek deafults
                if (!PlaneDeafults.planeTemplates.TryGetValue(selectedModel, out var template))
                {
                    MessageBox.Show("Modeli i avionit nuk u gjet.");
                    return;
                }

                //Marrja e te dhenave te avionit nga fushat per tu bere gati epr tu cuar ne databaze
                var newPlane = new Planes
                {
                    Model = selectedModel,
                    PlaneId = int.Parse(txtPlaneId.Text),
                    Registration = txtPlaneRegistration.Text,
                    SeatCount = (int)numSeatNr.Value,
                    RangeKm = (int)numMaxRange.Value,
                    Status = cbPlaneStatus.SelectedItem?.ToString(),
                    HasClasses = template.HasClasses,
                    BuisnessFactor = template.BuisnessFactor,
                    FirstClassFactor = template.FirstClassFactor,
                    CreatedDate = DateTime.Today
                };

                //Shtimi i avionit ne databaze
                Program.PlanesManager.AddPlane(newPlane);
                MessageBox.Show("Avioni u shtua me sukses!");
                btnClear_Click(null, null);
            }
            catch (FlightManagementException exception)
            {
                MessageBox.Show(exception.Message, "Gabim në shtim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gabim gjatë shtimit: " + ex.Message);
            }
            //Rifreskimi i data grid
            FillDataGridView();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Marrja e id se avionit te selektuar
            int id = selectedPlaneDbId;
            //Nese ai eshte -1 do te thote qe nuk ekziston ne databaze
            if (selectedPlaneDbId == -1)
            {
                MessageBox.Show("Zgjidh një avion për perditesim.");
                return;
            }

            try
            {
                //Marrja e modelit te avionit
                string selectedModel = cbPlaneType.SelectedItem?.ToString();
                //Kontrollimi nese ai avion ndodhet apo jo ne databaze, qe te mos behet hyrja e nje avioni te panjohur ne databaze, duke cuar ne gabime te ndryshme
                if (!PlaneDeafults.planeTemplates.TryGetValue(selectedModel, out var template))
                {
                    MessageBox.Show("Modeli i avionit nuk u gjet.");
                    return;
                }
                //Marrja e te dhenave te reja nga fushat dhe per tu bere gati per tu updatuar ne databaze
                var updatedPlane = new Planes
                {
                    Model = selectedModel,
                    PlaneId = int.Parse(txtPlaneId.Text),
                    Registration = txtPlaneRegistration.Text,
                    SeatCount = (int)numSeatNr.Value,
                    RangeKm = (int)numMaxRange.Value,
                    Status = cbPlaneStatus.SelectedItem?.ToString(),
                    HasClasses = template.HasClasses,
                    BuisnessFactor = template.BuisnessFactor,
                    FirstClassFactor = template.FirstClassFactor,
                    UpdatedDate = DateTime.Now
                };
                //Dergimi i te dhenave ne databaze
                Program.PlanesManager.Update(selectedPlaneDbId, updatedPlane);
                MessageBox.Show("Avioni u përditësua me sukses!");
                //Pastrimi i fushave
                btnClear_Click(null, null);
            }
            catch (FlightManagementException exception)
            {
                MessageBox.Show(exception.Message, "Gabim në editim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gabim gjatë përditësimit: " + ex.Message);
            }
            //Rifreskimi i data grid
            FillDataGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Marrja e id per avionin e selektuar
            int id = selectedPlaneDbId;
            //Kontrollimi nese ai avion ekziston ne databaze
            if (id == -1)
            {
                MessageBox.Show("Zgjidh një avion për fshirje.");
                return;
            }
            //Konfirmimi nese avioni do te fshihet apo jo
            var confirm = MessageBox.Show("Jeni i sigurt që doni të fshini këtë avion?", "Konfirmim", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                //Fshirja e avionit nga databaza
                Program.PlanesManager.Delete(selectedPlaneDbId);
                MessageBox.Show("Avioni u fshi me sukses!");
                //Pastrimi i fushave
                btnClear_Click(null, null);
                //Rifreskimi i datagrid
                FillDataGridView();
            }
        }

        private void FillDataGridView()
        {
            //Gjenerimi i kolonave per ne datagrid
            dgData.AutoGenerateColumns = true;
            dgData.RowHeadersVisible = false;
            dgData.DataSource = Program.PlanesManager.GetAll();
            DataGridViewCostumizer.StylePlaneGrid(dgData);
        }

        private void dgData_CellClick(object sender, DataGridViewCellEventArgs e)
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
                if (e.RowIndex != -1)
                {
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;
                    btnAdd.Enabled = false;

                    //Marrja e id se avionit te selektuar
                    DataGridViewRow row = dgData.Rows[e.RowIndex];
                    selectedPlaneDbId = Convert.ToInt32(row.Cells["Id"].Value);
                    //Marrja e te dhenave te tjera per te plotesuar fushat e nevojshme qe jane te shfaqura ne panel
                    cbPlaneType.SelectedItem = row.Cells["Model"].Value.ToString();
                    txtPlaneId.Text = row.Cells["PlaneId"].Value.ToString();
                    txtPlaneRegistration.Text = row.Cells["Registration"].Value.ToString();
                    numSeatNr.Value = Convert.ToDecimal(row.Cells["SeatCount"].Value);
                    numMaxRange.Value = Convert.ToDecimal(row.Cells["RangeKm"].Value);
                    cbPlaneStatus.Text = row.Cells["Status"].Value.ToString();
                }
            }
            else
            {

            }
        }
    }
}
