using FlightManagement.Core;
using FlightManagement.Core.Data;
using FlightManagement.Core.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FlightManagement.PL.Admin.Biletat
{
    public partial class FrmBiletat : Form
    {
        private readonly AppDbContext _db = new AppDbContext();

        public FrmBiletat()
        {
            InitializeComponent();
            dgvBiletat.SelectionChanged += dgvBiletat_SelectionChanged;
            dgvBiletat.MultiSelect = true;
            dgvBiletat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBiletat.CellFormatting += dgvBiletat_CellFormatting;
            dgvBiletat.CellContentClick += dgvBiletat_CellContentClick;

            btnPranoZgjedhje.Visible = false;
            btnAnuloZgjedhje.Visible = false;


            cmbKlasaFilter.Items.AddRange(new[]
            {
                "Të gjitha",
                "First",
                "Business",
                "Economy"
            });
            cmbKlasaFilter.SelectedIndexChanged += (_, __) => AplikoFiltriminSipasKlases();
            cmbKlasaFilter.SelectedIndex = 0;

            AplikoFiltriminSipasKlases();
        }

        private void AplikoFiltriminSipasKlases()
        {
            string klasa = cmbKlasaFilter.SelectedItem?.ToString() ?? "";
            string kerko = txtKerko.Text?.Trim().ToLower() ?? "";

            var query = _db.Biletat
                           .Include(b => b.Route)
                           .Where(b => b.Statusi == "Ne Pritje");

            if (!string.IsNullOrEmpty(klasa) && klasa != "Të gjitha")
                query = query.Where(b => b.Klasa.Contains(klasa));

            if (!string.IsNullOrWhiteSpace(kerko))
                query = query.Where(b =>
                    b.EmriPasagjerit.ToLower().Contains(kerko)
                );

            var displayList = query
                .Select(b => new
                {
                    b.Id,
                    Pasagjer = b.EmriPasagjerit,
                    Fluturimi = b.Fluturimi,
                    Data = b.DataRezervimit.ToString("dd/MM/yyyy"),
                    b.Statusi,
                    b.Klasa
                })
                .ToList();

            dgvBiletat.Columns.Clear();
            dgvBiletat.DataSource = displayList;

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
            dgvBiletat.Columns["Fluturimi"].MinimumWidth = 300;
            dgvBiletat.Columns.Add(anuloBtn);
        }

        private void dgvBiletat_SelectionChanged(object sender, EventArgs e)
        {
            int selectedCount = dgvBiletat.SelectedRows.Count;
            btnPranoZgjedhje.Visible = selectedCount >= 2;
            btnAnuloZgjedhje.Visible = selectedCount >= 2;
        }

        private void dgvBiletat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvBiletat.Rows.Count)
                return;

            if (dgvBiletat.Rows[e.RowIndex].IsNewRow)
                return;

            if (dgvBiletat.Columns[e.ColumnIndex] is not DataGridViewButtonColumn)
                return;

            if (!dgvBiletat.Columns.Contains("Id"))
                return;

            var idCell = dgvBiletat.Rows[e.RowIndex].Cells["Id"];
            if (idCell == null || idCell.Value == null)
                return;

            if (!int.TryParse(idCell.Value.ToString(), out int id))
                return;

            var bilet = _db.Biletat.Find(id);
            if (bilet == null) return;

            string clickedCol = dgvBiletat.Columns[e.ColumnIndex].Name;
            if (clickedCol == "PranoButton")
            {
                if (MessageBox.Show(
                        "Pranoni këtë biletë?",
                        "Konfirmo",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    ) == DialogResult.Yes)
                {
                    bilet.Statusi = "Pranuar";
                    _db.SaveChanges();
                    AplikoFiltriminSipasKlases();
                }
            }
            else if (clickedCol == "AnuloButton")
            {
                if (MessageBox.Show(
                        "Anuloni këtë biletë?",
                        "Konfirmo",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    ) == DialogResult.Yes)
                {
                    bilet.Statusi = "Anuluar";
                    _db.SaveChanges();
                    AplikoFiltriminSipasKlases();
                }
            }
        }

        private void btnPranoZgjedhje_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Pranoni biletat e zgjedhura?", "Konfirmo",
                MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            foreach (DataGridViewRow row in dgvBiletat.SelectedRows)
            {
                int id = (int)row.Cells["Id"].Value;
                var b = _db.Biletat.Find(id);
                if (b != null) b.Statusi = "Pranuar";
            }
            _db.SaveChanges();
            AplikoFiltriminSipasKlases();
        }

        private void btnAnuloZgjedhje_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anuloni biletat e zgjedhura?", "Konfirmo",
                MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            foreach (DataGridViewRow row in dgvBiletat.SelectedRows)
            {
                int id = (int)row.Cells["Id"].Value;
                var b = _db.Biletat.Find(id);
                if (b != null) b.Statusi = "Anuluar";
            }
            _db.SaveChanges();
            AplikoFiltriminSipasKlases();
        }

        private void dgvBiletat_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvBiletat.Rows[e.RowIndex];
            if (!(row.Cells["Id"].Value is int id)) return;
            var bilet = _db.Biletat.Find(id);
            if (bilet == null) return;

            switch (bilet.Klasa)
            {
                case "First":
                    row.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                    row.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    break;
                case "Business":
                    row.DefaultCellStyle.BackColor = Color.LightCyan;
                    break;
                case "Economy":
                    row.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    break;
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
