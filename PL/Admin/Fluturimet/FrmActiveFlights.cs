using FlightManagement.Core.Data.Entities;
using FlightManagement.Core.Logic.Managers;
using FontAwesome.Sharp;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightManagement.PL.Admin.Fluturimet
{
    public partial class FrmActiveFlights : Form
    {
        private int selectedPlaneId;
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

            btnRouteSwitch.Enabled = false;
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
        private int GetPlaneIdFromRow(int rowIndex)
        {
            return Convert.ToInt32(dgActivePlanes.Rows[rowIndex].Cells["Id"].Value);
        }
        private void ShowRoutesForPlane(int planeId)
        {
            btnRouteSwitch.Enabled = true;

            var routes = Program.RoutesManager
                                .GetAllRoutes()
                                .Where(r => r.Status == "Aktiv" && r.PlaneId == planeId)
                                .ToList();

            BindRoutesGrid(routes);
        }
        private void BindRoutesGrid(List<Route> routes)
        {
            dgSelectedPlaneRoute.AutoGenerateColumns = true;
            dgSelectedPlaneRoute.DataSource = routes;

            var cols = new[]
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

            foreach (DataGridViewColumn c in dgSelectedPlaneRoute.Columns)
                c.Visible = cols.Contains(c.Name);

            dgSelectedPlaneRoute.Columns["PlaneId"].HeaderText = "ID e Avionit";
            dgSelectedPlaneRoute.Columns["Departure"].HeaderText = "Nisja";
            dgSelectedPlaneRoute.Columns["Arrival"].HeaderText = "Mbërritja";
            dgSelectedPlaneRoute.Columns["DepartureDay"].HeaderText = "Dita";
            dgSelectedPlaneRoute.Columns["StartTime"].HeaderText = "Ora Nisjes";
            dgSelectedPlaneRoute.Columns["EndTime"].HeaderText = "Ora Mbërritjes";
            dgSelectedPlaneRoute.Columns["StartTime"].DefaultCellStyle.Format = "hh\\:mm";
            dgSelectedPlaneRoute.Columns["EndTime"].DefaultCellStyle.Format = "hh\\:mm";
            dgSelectedPlaneRoute.Columns["Status"].HeaderText = "Statusi";
            dgSelectedPlaneRoute.Columns["Price"].HeaderText = "Çmimi";
            dgSelectedPlaneRoute.Columns["CreatedDate"].HeaderText = "Data Shtimit";
        }
        private void dgActivePlanes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Kontrollim nese rrjeshti qe admini ka shtypur eshte ai qe deshiron, 
            //dhe gjithashtu si mase brojtese kunder klikimit pa qellim mbi cell dhe fshirja e te dhenave te meparshme
            DialogResult result = MessageBox.Show(
                "Deshiron te marresh te dhenat e ketij avioni?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                if (e.RowIndex < 0) return;

                btnRouteSwitch.Enabled = true;

                int planeId = GetPlaneIdFromRow(e.RowIndex);
                ShowRoutesForPlane(planeId);
            }
            else
            {

            }
        }

        private void btnPlaneExport_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.FileName = "Planes.csv";

            var selectedFileResult = saveFileDialog1.ShowDialog();
            if (selectedFileResult == DialogResult.OK)
            {
                var fileName = saveFileDialog1.FileName;
                var planeRows = new List<string>
                    {
                        "Id,Id e Avionit,Modeli,Regjistrimi,Numri i sendiljeve,Rrezja,Statusi,Ka Klase?,Data e krijimit"
                    };
                var planes = Program.PlanesManager.GetAll();
                foreach (var plane in planes)
                {
                    planeRows.Add(string.Join(
                        ",",
                        plane.Id,
                        plane.PlaneId,
                        plane.Model,
                        plane.Registration,
                        plane.SeatCount,
                        plane.RangeKm,
                        plane.Status,
                        plane.HasClasses,
                        plane.CreatedDate.ToString("yyyy-MM-dd")
                    ));
                }
                File.WriteAllLines(fileName, planeRows.ToArray());
            }
        }

        private void btnRouteExport_Click(object sender, EventArgs e)
        {
            saveFileDialog2.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog2.DefaultExt = "csv";
            saveFileDialog2.FileName = "Routes.csv";

            var selectedFileResult = saveFileDialog2.ShowDialog();
            if (selectedFileResult == DialogResult.OK)
            {
                var fileName = saveFileDialog2.FileName;
                var routesRows = new List<string>
                    {
                        "Id,Id e Avionit,Nisja,Mbarritja,Statusi,Dita e nisjes,Cmimi,Data e krijimit"
                    };
                var routes = Program.RoutesManager.GetAllRoutes();
                foreach (var route in routes)
                {
                    routesRows.Add(string.Join(
                        ",",
                        route.Id,
                        route.PlaneId,
                        route.Departure,
                        route.Arrival,
                        route.Status,
                        route.DepartureDay,
                        route.Price,
                        route.CreatedDate.ToString("yyyy-MM-dd")
                    ));
                }
                File.WriteAllLines(fileName, routesRows.ToArray());
            }
        }

        private void btnWeekly_Click(object sender, EventArgs e)
        {
            var allTickets = new TicketsManager().GetAll().ToList();

            var calendar = CultureInfo.CurrentCulture.Calendar;
            var weekRule = CalendarWeekRule.FirstDay;
            var firstDayOfWeek = DayOfWeek.Monday;
            int currentWeek = calendar.GetWeekOfYear(DateTime.Now, weekRule, firstDayOfWeek);

            // 3) Filter tickets so that only those booked in 'this' week remain:
            var ticketsThisWeek = allTickets
                .Where(b =>
                    b.Statusi == "Pranuar" &&
                    calendar.GetWeekOfYear(
                        b.DataRezervimit,
                        weekRule,
                        firstDayOfWeek
                    ) == currentWeek
                )
                .ToList();



            // 4) If there are no tickets, show a friendly message and return:
            if (!ticketsThisWeek.Any())
            {
                MessageBox.Show(
                    "Nuk u gjendën bileta për javën aktuale.",
                    "Raporti Javore",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            // 5) Compute your metrics:

            // 5a) Total number of passengers (i.e., total tickets) this week
            int totalPassengers = ticketsThisWeek.Count;


            // 5b) Most-frequent departure airport
            var topDepGroup = ticketsThisWeek
                .GroupBy(b => b.Route.Departure)
                .Select(g => new { Airport = g.Key, Count = g.Count() })
                .OrderByDescending(x => x.Count)
                .First();
            string mostFrequentDeparture = topDepGroup.Airport;
            int depCount = topDepGroup.Count;

            // 5c) Most-frequent arrival airport
            var topArrGroup = ticketsThisWeek
                .GroupBy(b => b.Route.Arrival)
                .Select(g => new { Airport = g.Key, Count = g.Count() })
                .OrderByDescending(x => x.Count)
                .First();
            string mostFrequentArrival = topArrGroup.Airport;
            int arrCount = topArrGroup.Count;

            // 5d) Average ticket price (if you have price info in Bileta)
            decimal avgPrice = ticketsThisWeek.Average(b => b.Price);

            // 5e) (Optional) Count per class (Economy/Business/First, etc.)
            // Example: how many “Klasa = Economy” vs “Business” this week
            var classBreakdown = ticketsThisWeek
                .GroupBy(b => b.Klasa)
                .Select(g => new { Klasa = g.Key, Count = g.Count() })
                .OrderByDescending(x => x.Count)
                .ToList();

            // 6) Build the multiline report string
            var sb = new StringBuilder();
            sb.AppendLine($"==== Raporti për Javën {currentWeek} ====");
            sb.AppendLine($"Total pasagjerë (bileta): {totalPassengers}");
            sb.AppendLine($"Aeroporti më i frekuentuar (nisje): {mostFrequentDeparture} ({depCount} bileta)");
            sb.AppendLine($"Aeroporti më i frekuentuar (mbërritje): {mostFrequentArrival} ({arrCount} bileta)");
            sb.AppendLine($"Çmimi mesatar i biletës: {avgPrice:0.00} EUR");

            // 6a) Append breakdown by class, if you want to show it
            sb.AppendLine();
            sb.AppendLine("Numri i biletave sipas klasës:");
            foreach (var kv in classBreakdown)
            {
                sb.AppendLine($"  • {kv.Klasa}: {kv.Count}");
            }

            // 7) Show everything in a MessageBox
            MessageBox.Show(
                sb.ToString(),
                "Raporti Javore",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
