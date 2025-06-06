using FlightManagement.Core;
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
            var activePlanes = Program.PlanesManager
                              .GetAll()
                              .Where(p => p.Status == "Aktiv")
                              .ToList();

            dgActivePlanes.AutoGenerateColumns = true;
            dgActivePlanes.DataSource = activePlanes;
            dgActivePlanes.RowHeadersVisible = false;
            dgSelectedPlaneRoute.AutoGenerateColumns = true;
            dgSelectedPlaneRoute.DataSource = new List<Route>();

            DataGridViewCostumizer.StyleActiveFlightsGrid(dgActivePlanes, dgSelectedPlaneRoute);
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
            dgSelectedPlaneRoute.RowHeadersVisible = false;

            DataGridViewCostumizer.StyleRouteGrid(dgSelectedPlaneRoute);
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

            var ticketsThisWeek = allTickets
                .Where(b =>
                    calendar.GetWeekOfYear(
                        b.DataRezervimit,
                        weekRule,
                        firstDayOfWeek
                    ) == currentWeek
                )
                .ToList();

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

            int totalPassengers = ticketsThisWeek.Count;

            //Aeroporti me i frekuentuar per nisje
            var topDepGroup = ticketsThisWeek
                .GroupBy(b => b.Route.Departure)
                .Select(g => new { Airport = g.Key, Count = g.Count() })
                .OrderByDescending(x => x.Count)
                .First();
            string mostFrequentDeparture = topDepGroup.Airport;
            int depCount = topDepGroup.Count;

            //Aerorti me i frekuentuar per mbërritje
            var topArrGroup = ticketsThisWeek
                .GroupBy(b => b.Route.Arrival)
                .Select(g => new { Airport = g.Key, Count = g.Count() })
                .OrderByDescending(x => x.Count)
                .First();
            string mostFrequentArrival = topArrGroup.Airport;
            int arrCount = topArrGroup.Count;

            //Cmimi mesatar i biletës
            decimal avgPrice = ticketsThisWeek.Average(b => b.Price);

            //Ndarja sipas klasave
            var classBreakdown = ticketsThisWeek
                .GroupBy(b => b.Klasa)
                .Select(g => new { Klasa = g.Key, Count = g.Count() })
                .OrderByDescending(x => x.Count)
                .ToList();

            //Nderitmi i tekstit per raportin javor
            var sb = new StringBuilder();
            sb.AppendLine($"==== Raporti për Javën {currentWeek} ====");
            sb.AppendLine($"Total pasagjerë (bileta): {totalPassengers}");
            sb.AppendLine($"Aeroporti më i frekuentuar (nisje): {mostFrequentDeparture} ({depCount} bileta)");
            sb.AppendLine($"Aeroporti më i frekuentuar (mbërritje): {mostFrequentArrival} ({arrCount} bileta)");
            sb.AppendLine($"Çmimi mesatar i biletës: {avgPrice:0.00} EUR");       
            sb.AppendLine();
            sb.AppendLine("Numri i biletave sipas klasës:");
            foreach (var kv in classBreakdown)
            {
                sb.AppendLine($"  • {kv.Klasa}: {kv.Count}");
            }

            MessageBox.Show(
                sb.ToString(),
                "Raporti Javore",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
