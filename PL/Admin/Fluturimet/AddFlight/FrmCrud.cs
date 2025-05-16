using FlightManagement.Core.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            cbPlaneStatus.Items.Add("Aktiv");
            cbPlaneStatus.Items.Add("Jashtë Shërbimi");
            cbPlaneType.Items.AddRange(PlaneDeafults.planeTemplates.Keys.ToArray());
            cbPlaneStatus.SelectedIndex = -1;
            isLoaded = true;
        }

        private void btnSwitchPanelData_Click(object sender, EventArgs e)
        {
            btnSwitchPanelData.Visible = false;
            btnSwitchPanelSeatMap.Visible = true;

            pnlData.Visible = true;
            pnlSeatMap.Visible = false;
        }

        private void btnSwitchPanelSeatMap_Click(object sender, EventArgs e)
        {
            btnSwitchPanelSeatMap.Visible = false;
            btnSwitchPanelData.Visible = true;

            pnlData.Visible = false;
            pnlSeatMap.Visible = true;
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


                pbSeatMap.Image = null;

                string imageFileName = selectedPlaneType + ".png"; 
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

        
    }
}
