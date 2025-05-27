using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightManagement.Core.Data;
using FlightManagement.Core.Data.Entities;

namespace FlightManagement.PL.Admin.Biletat
{
    public partial class FrmBiletat : Form
    {
        private AppDbContext _db = new AppDbContext();
        private Bileta biletaTest3;

        public FrmBiletat()
        {
            InitializeComponent();
            this.dgvBiletat.SelectionChanged += new System.EventHandler(this.dgvBiletat_SelectionChanged);
            dgvBiletat.MultiSelect = true;
            dgvBiletat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvBiletat.CellFormatting += dgvBiletat_CellFormatting;

            btnPranoZgjedhje.Visible = false;
            btnAnuloZgjedhje.Visible = false;

            cmbKlasaFilter.Items.Add("Të gjitha");
            cmbKlasaFilter.Items.Add("First Class");
            cmbKlasaFilter.Items.Add("Business Class");
            cmbKlasaFilter.Items.Add("Economy Class");
            cmbKlasaFilter.SelectedIndex = 0;

            cmbKlasaFilter.SelectedIndexChanged += cmbKlasaFilter_SelectedIndexChanged;

            ShtoBileteTest();
            ShtoBileteTest2();
            //LoadBiletat();
            AplikoFiltriminSipasKlases();

        }
        private void cmbKlasaFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplikoFiltriminSipasKlases();
        }
        private void AplikoFiltriminSipasKlases()
        {
            string klasa = cmbKlasaFilter.SelectedItem?.ToString();
            string kerko = txtKerko.Text?.Trim().ToLower();

            var biletat = _db.Biletat
                             .Where(b => b.Statusi == "Ne Pritje")
                             .AsQueryable();

            if (!string.IsNullOrEmpty(klasa) && klasa != "Të gjitha")
                biletat = biletat.Where(b => b.Klasa == klasa);

            if (!string.IsNullOrWhiteSpace(kerko))
                biletat = biletat.Where(b => b.EmriPasagjerit.ToLower().Contains(kerko));

            dgvBiletat.Columns.Clear();
            dgvBiletat.DataSource = biletat.ToList();

            var pranoBtn = new DataGridViewButtonColumn
            {
                Name = "PranoButton",
                HeaderText = "Veprim",
                Text = "Prano",
                UseColumnTextForButtonValue = true
            };
            dgvBiletat.Columns.Add(pranoBtn);

            var anuloBtn = new DataGridViewButtonColumn
            {
                Name = "AnuloButton",
                HeaderText = "",
                Text = "Anulo",
                UseColumnTextForButtonValue = true
            };
            dgvBiletat.Columns.Add(anuloBtn);
        }


        private void dgvBiletat_SelectionChanged(object sender, EventArgs e)
        {
            int selectedCount = dgvBiletat.SelectedRows.Count;

            // Butonat shfaqen VETËM nëse janë përzgjedhur dy ose më shumë rreshta
            btnPranoZgjedhje.Visible = selectedCount >= 2;
            btnAnuloZgjedhje.Visible = selectedCount >= 2;
        }


        private void LoadBiletat()
        {
            var biletatNePritje = _db.Biletat
                                    .Where(b => b.Statusi == "Ne Pritje")
                                    .ToList();
            dgvBiletat.DataSource = biletatNePritje;
            // Shto kolonën e butonit "Prano"
            if (!dgvBiletat.Columns.Contains("PranoButton"))
            {
                var pranoBtn = new DataGridViewButtonColumn();
                pranoBtn.Name = "PranoButton";
                pranoBtn.HeaderText = "Veprim";
                pranoBtn.Text = "Prano";
                pranoBtn.UseColumnTextForButtonValue = true;
                dgvBiletat.Columns.Add(pranoBtn);
            }

            // Shto kolonën e butonit "Anulo"
            if (!dgvBiletat.Columns.Contains("AnuloButton"))
            {
                var anuloBtn = new DataGridViewButtonColumn();
                anuloBtn.Name = "AnuloButton";
                anuloBtn.HeaderText = "";
                anuloBtn.Text = "Anulo";
                anuloBtn.UseColumnTextForButtonValue = true;
                dgvBiletat.Columns.Add(anuloBtn);
            }

        }

        private void dgvBiletat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var id = (int)dgvBiletat.Rows[e.RowIndex].Cells["Id"].Value;
                var bileta = _db.Biletat.FirstOrDefault(b => b.Id == id);
                if (bileta == null) return;
                bool kaZgjedhje = dgvBiletat.SelectedRows.Count > 0;
                btnPranoZgjedhje.Visible = kaZgjedhje;
                btnAnuloZgjedhje.Visible = kaZgjedhje;

                var clickedColumn = dgvBiletat.Columns[e.ColumnIndex].Name;

                if (clickedColumn == "PranoButton")
                {
                    var konfirmim = MessageBox.Show("Je i sigurt që dëshiron të pranosh këtë biletë?", "Konfirmo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (konfirmim == DialogResult.Yes)
                    {
                        bileta.Statusi = "Pranuar";
                        _db.SaveChanges();
                        LoadBiletat(); // heqim MessageBox.Show këtu
                    }
                }
                else if (clickedColumn == "AnuloButton")
                {
                    var konfirmim = MessageBox.Show("Je i sigurt që dëshiron të anulosh këtë biletë?", "Konfirmo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (konfirmim == DialogResult.Yes)
                    {
                        bileta.Statusi = "Anuluar";
                        _db.SaveChanges();
                        LoadBiletat(); // heqim MessageBox.Show këtu
                    }
                }


            }
        }


        private void btnPranoZgjedhje_Click(object sender, EventArgs e)
        {
            var konfirmim = MessageBox.Show("Je i sigurt që dëshiron të pranosh biletat e përzgjedhura?", "Konfirmo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (konfirmim != DialogResult.Yes)
                return;

            foreach (DataGridViewRow row in dgvBiletat.SelectedRows)
            {
                int id = (int)row.Cells["Id"].Value;
                var bileta = _db.Biletat.FirstOrDefault(b => b.Id == id);
                if (bileta != null)
                {
                    bileta.Statusi = "Pranuar";
                }
            }
            _db.SaveChanges();
            LoadBiletat();
        }


        private void btnAnuloZgjedhje_Click(object sender, EventArgs e)
        {
            var konfirmim = MessageBox.Show("Je i sigurt që dëshiron të anulosh biletat e përzgjedhura?", "Konfirmo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (konfirmim != DialogResult.Yes)
                return;

            foreach (DataGridViewRow row in dgvBiletat.SelectedRows)
            {
                int id = (int)row.Cells["Id"].Value;
                var bileta = _db.Biletat.FirstOrDefault(b => b.Id == id);
                if (bileta != null)
                {
                    bileta.Statusi = "Anuluar";
                }
            }
            _db.SaveChanges();
            LoadBiletat();
        }


        private void ShtoBileteTest()
        {
            var biletaTest = new FlightManagement.Core.Data.Entities.Bileta
            {
                EmriPasagjerit = "Alma",
                Fluturimi = "Prishtinë - Vjenë",
                DataRezervimit = DateTime.Now,
                Statusi = "Ne Pritje",
                Klasa = "Business Class" // Shto këtë rresht
            };

            _db.Biletat.Add(biletaTest);
            _db.SaveChanges();
            LoadBiletat();
        }

        private void ShtoBileteTest2()
        {

            var biletaTest2 = new FlightManagement.Core.Data.Entities.Bileta
            {
                EmriPasagjerit = "Turi",
                Fluturimi = "Prishtinë - Vjenë",
                DataRezervimit = DateTime.Now,
                Statusi = "Ne Pritje",
                Klasa = "First Class" // Shto këtë rresht
            };

            _db.Biletat.Add(biletaTest2);
            _db.SaveChanges();
            LoadBiletat();
        }
        private void dgvBiletat_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || dgvBiletat.Rows[e.RowIndex].DataBoundItem == null)
                return;

            var row = dgvBiletat.Rows[e.RowIndex];
            var bileta = row.DataBoundItem as FlightManagement.Core.Data.Entities.Bileta;

            if (bileta != null)
            {
                switch (bileta.Klasa)
                {
                    case "First Class":
                        row.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                        row.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                        break;
                    case "Business Class":
                        row.DefaultCellStyle.BackColor = Color.LightCyan;
                        break;
                    case "Economy Class":
                        row.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                        break;
                }
            }
        }

        private void txtKerko_TextChanged(object sender, EventArgs e)
        {
            AplikoFiltriminSipasKlases();
        }

        private void FrmBiletat_Click(object sender, EventArgs e)
        {
            AplikoFiltriminSipasKlases();
        }
    }
}
