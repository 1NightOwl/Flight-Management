using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Core
{
    public class DataGridViewCostumizer
    {
        public static void StylePlaneGrid(DataGridView dgv)
        {
            // 1a) Bazë: Krijo header‐in si të errët + tekst të bardhë
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(60, 75, 85); // një gri‐jeshile i errët
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 30;

            // 1b) Rreshta alternues: e bardhë vs. e plur
            dgv.BackgroundColor = Color.WhiteSmoke;
            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 241, 246);

            // 1c) Kur zgjidhet një rresht: blu i çelët
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 153, 255);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            // 1d) Kolonat bazë
            dgv.Columns["Id"].Visible = false;
            dgv.Columns["PlaneId"].HeaderText = "ID e Avionit";
            dgv.Columns["Model"].HeaderText = "Modeli";
            dgv.Columns["Registration"].HeaderText = "Regjistrimi";
            dgv.Columns["SeatCount"].HeaderText = "Vendesh";
            dgv.Columns["RangeKm"].HeaderText = "Rezia (km)";
            dgv.Columns["Status"].HeaderText = "Statusi";
            dgv.Columns["HasClasses"].HeaderText = "Ka Klasa?";
            dgv.Columns["BuisnessFactor"].HeaderText = "Koef. Biznes";
            dgv.Columns["FirstClassFactor"].HeaderText = "Koef. First";
            dgv.Columns["CreatedDate"].HeaderText = "Data e Shtimit";
            dgv.Columns["UpdatedDate"].HeaderText = "Data e Përditësimit";

            // 1e) Formato datat (mm/dd/yyyy) dhe vendos “—” për null
            if (dgv.Columns.Contains("CreatedDate"))
                dgv.Columns["CreatedDate"].DefaultCellStyle.Format = "MM/dd/yyyy";
            if (dgv.Columns.Contains("UpdatedDate"))
            {
                dgv.Columns["UpdatedDate"].DefaultCellStyle.Format = "MM/dd/yyyy";
                dgv.Columns["UpdatedDate"].DefaultCellStyle.NullValue = "—";
            }

            // 1f) Centërso kolonat e disa fushave për pamje më të pastrë
            dgv.Columns["SeatCount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["RangeKm"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["HasClasses"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public static void StyleRouteGrid(DataGridView dgv)
        {
            // 2a) Header stil
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(70, 90, 100);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 30;

            // 2b) Rreshta alternues
            dgv.BackgroundColor = Color.WhiteSmoke;
            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 248, 251);

            // 2c) Selektimi
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            // 2d) Kolonat bazë
            dgv.Columns["Plane"].Visible = false;
            dgv.Columns["Id"].Visible = false;

            dgv.Columns["PlaneId"].HeaderText = "ID e Avionit";
            dgv.Columns["Departure"].HeaderText = "Nisja";
            dgv.Columns["Arrival"].HeaderText = "Mbërritja";
            dgv.Columns["DepartureDay"].HeaderText = "Dita";
            dgv.Columns["StartTime"].HeaderText = "Ora Nisjes";
            dgv.Columns["EndTime"].HeaderText = "Ora Mbërritjes";
            dgv.Columns["Status"].HeaderText = "Statusi";
            dgv.Columns["Price"].HeaderText = "Çmimi";
            dgv.Columns["CreatedDate"].HeaderText = "Data e Shtimit";
            dgv.Columns["UpdatedDate"].HeaderText = "Data e Përditësimit";

            dgv.Columns["StartTime"].DefaultCellStyle.Format = "hh\\:mm";
            dgv.Columns["EndTime"].DefaultCellStyle.Format = "hh\\:mm";
            dgv.Columns["CreatedDate"].DefaultCellStyle.Format = "MM/dd/yyyy";
            dgv.Columns["UpdatedDate"].DefaultCellStyle.Format = "MM/dd/yyyy";
            dgv.Columns["UpdatedDate"].DefaultCellStyle.NullValue = "—";

            // 2e) Center alignment për disa
            dgv.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["DepartureDay"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public static void StyleUserGrid(DataGridView dgv)
        {
            // 3a) Header
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(100, 50, 50);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 30;

            // 3b) Rreshta alternues
            dgv.BackgroundColor = Color.WhiteSmoke;
            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 238, 238);

            // 3c) Selektimi
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 100, 100);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            // 3d) Kolonat bazë
            dgv.Columns["Password"].Visible = false;
            dgv.Columns["Biletat"].Visible = false;

            dgv.Columns["Id"].HeaderText = "ID";
            dgv.Columns["Username"].HeaderText = "Emri i Përdoruesit";
            dgv.Columns["Email"].HeaderText = "Email";
            dgv.Columns["Role"].HeaderText = "Roli";
            dgv.Columns["CreatedDate"].HeaderText = "Data e Krijimit";
            dgv.Columns["UpdatedDate"].HeaderText = "Data e Përditësimit";

            dgv.Columns["UpdatedDate"].DefaultCellStyle.Format = "MM/dd/yyyy";
            dgv.Columns["UpdatedDate"].DefaultCellStyle.NullValue = "—";

            // 3e) Një stil i lehtë me bazë role: Admin = #D4AF37 (gri‐ari), User = i bardhë
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells["Role"].Value?.ToString() == "Admin")
                    row.DefaultCellStyle.BackColor = Color.FromArgb(250, 250, 230);
                else
                    row.DefaultCellStyle.BackColor = Color.White;
            }
        }

        public static void StyleActiveFlightsGrid(DataGridView dgvActivePlanes, DataGridView dgvRoutes)
        {
            // 4a) Për avionët (dgActivePlanes): e ngjashme me StylePlaneGrid, por pa CreatedDate/UpdatedDate
            dgvActivePlanes.EnableHeadersVisualStyles = false;
            dgvActivePlanes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 80, 90);
            dgvActivePlanes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvActivePlanes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvActivePlanes.ColumnHeadersHeight = 30;

            dgvActivePlanes.BackgroundColor = Color.WhiteSmoke;
            dgvActivePlanes.RowsDefaultCellStyle.BackColor = Color.White;
            dgvActivePlanes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            dgvActivePlanes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 153, 255);
            dgvActivePlanes.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvActivePlanes.Columns["Id"].Visible = false;
            dgvActivePlanes.Columns["PlaneId"].HeaderText = "ID e Avionit";
            dgvActivePlanes.Columns["Model"].HeaderText = "Modeli i Avionit";
            dgvActivePlanes.Columns["SeatCount"].HeaderText = "Numri i Vendeve";
            dgvActivePlanes.Columns["HasClasses"].HeaderText = "Ka Klasa?";
            dgvActivePlanes.Columns["BuisnessFactor"].HeaderText = "Koef. Biznes";
            dgvActivePlanes.Columns["FirstClassFactor"].HeaderText = "Koef. First";

            // 4b) Për rrugët e avionit të zgjedhur (dgSelectedPlaneRoute)
            dgvRoutes.EnableHeadersVisualStyles = false;
            dgvRoutes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(70, 100, 110);
            dgvRoutes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRoutes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvRoutes.ColumnHeadersHeight = 30;

            dgvRoutes.BackgroundColor = Color.WhiteSmoke;
            dgvRoutes.RowsDefaultCellStyle.BackColor = Color.White;
            dgvRoutes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            dgvRoutes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 153, 255);
            dgvRoutes.DefaultCellStyle.SelectionForeColor = Color.White;

            string[] cols =
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

            foreach (DataGridViewColumn c in dgvRoutes.Columns)
                c.Visible = cols.Contains(c.Name);

            dgvRoutes.Columns["PlaneId"].HeaderText = "ID e Avionit";
            dgvRoutes.Columns["Departure"].HeaderText = "Nisja";
            dgvRoutes.Columns["Arrival"].HeaderText = "Mbërritja";
            dgvRoutes.Columns["DepartureDay"].HeaderText = "Dita";
            dgvRoutes.Columns["StartTime"].HeaderText = "Ora Nisjes";
            dgvRoutes.Columns["EndTime"].HeaderText = "Ora Mbërritjes";
            dgvRoutes.Columns["Status"].HeaderText = "Statusi";
            dgvRoutes.Columns["Price"].HeaderText = "Çmimi";
            dgvRoutes.Columns["CreatedDate"].HeaderText = "Data e Shtimit";

            dgvRoutes.Columns["StartTime"].DefaultCellStyle.Format = "hh\\:mm";
            dgvRoutes.Columns["EndTime"].DefaultCellStyle.Format = "hh\\:mm";
            if (dgvRoutes.Columns.Contains("CreatedDate"))
                dgvRoutes.Columns["CreatedDate"].DefaultCellStyle.Format = "MM/dd/yyyy";
        }

        public static void StyleTicketsGrid(DataGridView dgv)
        {
            // 5a) Header
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(80, 50, 50);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 30;

            // 5b) Bazë rreshtash
            dgv.BackgroundColor = Color.WhiteSmoke;
            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 20, 60);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            // 5c) Vendos butonat (supozuar që i krijoni në form)
            // Shkurtimisht: BTN “Prano” dhe “Anulo” i shtoni pas vendosjes së DataSource, jo këtu.

            // 5d) Kolonat bazë, me emra dhe formate
            dgv.Columns["Id"].Visible = false;
            dgv.Columns["Pasagjer"].HeaderText = "Pasagjer";
            dgv.Columns["Fluturimi"].HeaderText = "Fluturimi";
            dgv.Columns["Data"].HeaderText = "Data";
            dgv.Columns["Statusi"].HeaderText = "Statusi";
            dgv.Columns["Klasa"].HeaderText = "Klasa";

            // 5e) Për ngjyrosje sipas fushës “Klasa”, shtoji eventin CellFormatting
            // Nëse nuk e ke ngarkuar në form, mund ta vendosësh këtu:
            dgv.CellFormatting -= DgvTickets_CellFormatting;
            dgv.CellFormatting += DgvTickets_CellFormatting;
        }

        private static void DgvTickets_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var dgv = sender as DataGridView;
            if (dgv == null) return;

            if (dgv.Columns.Contains("Klasa"))
            {
                var cell = dgv.Rows[e.RowIndex].Cells["Klasa"];
                if (cell.Value == null) return;

                string klasa = cell.Value.ToString();
                switch (klasa)
                {
                    case "First":
                        dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                        dgv.Rows[e.RowIndex].DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                        break;
                    case "Business":
                        dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCyan;
                        break;
                    case "Economy":
                        dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                        break;
                    default:
                        dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                        break;
                }
            }
        }
    }
}

