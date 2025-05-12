using FlightManagement.PL.Start.Log_in;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightManagement.PL.Start.Loading
{
    public partial class FrmLoading : Form
    {
        public FrmLoading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pnlLoad.Width += 40;

            if (pnlLoad.Width >= 1482)
            {
                timer1.Stop();


                FrmLogIn main = new FrmLogIn();
                main.Show();
                this.Hide();
            }
        }
    }
}
