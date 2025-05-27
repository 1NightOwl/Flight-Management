using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightManagement.PL.User.Flights
{
    public partial class FrmBrowseFlights : Form
    {
        /*2 · FlowLayoutPanel as result rail
                AutoScroll = true so the vertical scrollbar appears automatically.

                FlowDirection = TopDown, WrapContents = false (gives one neat column).

                When you refresh, call flowPanel.SuspendLayout(); flowPanel.Controls.Clear(); … add cards … flowPanel.ResumeLayout(); to avoid flicker.

                Performance note: a few hundred cards are fine. If you might exceed ~500, consider virtual scrolling or paging, but for a student project the simple approach is enough.*/




        public FrmBrowseFlights()
        {
            InitializeComponent();
        }

        private void rbOneWay_CheckedChanged(object sender, EventArgs e)
        {
            lblReturn.Visible = false;
            dtReturn.Visible = false;
        }

        private void rbReturn_CheckedChanged(object sender, EventArgs e)
        {
            lblReturn.Visible = rbReturn.Checked;
            dtReturn.Visible = rbReturn.Checked;
        }

        private void FrmBrowseFlights_Load(object sender, EventArgs e)
        {
            chkDirect.Checked = true;
            rbReturn.Checked = true;
        }
    }
}
