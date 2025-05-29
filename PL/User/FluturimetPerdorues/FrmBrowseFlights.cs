using FlightManagement.Core;
using FlightManagement.Core.Data.Entities;
using FlightManagement.Core.Logic;
using FlightManagement.Core.Logic.Managers;
using FlightManagement.Core.Templates;
using FlightManagement.PL.User.FluturimetPerdorues;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightManagement.PL.User.Flights
{
    public partial class FrmBrowseFlights : Form
    {
        string[] Airports = RouteDeafults.Airports;
        public FrmBrowseFlights()
        {
            InitializeComponent();
            //this.Shown += FrmBrowseFlights_Shown;

            dtDepart.ValueChanged += dtDepart_ValueChanged;
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
            cbFrom.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTo.DropDownStyle = ComboBoxStyle.DropDownList;

            cbFrom.Items.AddRange(Airports);
            cbTo.Items.AddRange(Airports);

            chkDirect.Checked = true;
            rbReturn.Checked = true;

            dtReturn.Enabled = false;

            dtDepart.Value = DateTime.Today;
            dtDepart.MinDate = DateTime.Today;
            var minReturn = dtDepart.Value.Date.AddDays(1);

            dtReturn.MinDate = minReturn;
            dtReturn.Value = minReturn;
            chkDirect.CheckedChanged += (s, e) => ApplyFilter();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoSearch();
        }

        private void DoSearch()
        {
            if (cbFrom.SelectedItem == null || cbTo.SelectedItem == null)
            {
                MessageBox.Show("Please select both origin and destination.");
                return;
            }

            flpTickets.SuspendLayout();
            flpTickets.Visible = false;
            flpTickets.Controls.Clear();
            int count = (int)numPasangers.Value;
            var from = cbFrom.Text;
            var to = cbTo.Text;
            var date = dtDepart.Value.Date;
            var day = date.DayOfWeek.ToString();

            var dayName = dtDepart.Value.DayOfWeek.ToString();

            if (chkDirect.Checked)
            {
                var directs = new RoutesManager()
                                  .FindDirect(from, to, dayName);

                foreach (var route in directs)
                {
                    var legs = new List<Route> { route };
                    var card = new UcFlightCard();
                    card.LoadData(legs, date, count);
                    card.BuyClicked += Card_BuyClicked;
                    flpTickets.Controls.Add(card);
                }
            }
            else
            {
                var connections = new RoutesManager()
                                      .FindConnections(
                                          from, to, dayName,
                                          TimeSpan.FromMinutes(30),
                                          TimeSpan.FromHours(5)
                                      );

                foreach (var (leg1, leg2) in connections)
                {
                    var legs = new List<Route> { leg1, leg2 };
                    var card = new UcFlightCard();
                    card.LoadData(legs, date, count);
                    card.BuyClicked += Card_BuyClicked;
                    flpTickets.Controls.Add(card);
                }
            }

            if (flpTickets.Controls.Count == 0)
            {
                flpTickets.Controls.Add(new Label
                {
                    Text = "Nuk u gjet asnjë fluturim.",
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12, FontStyle.Italic)
                });
            }

            flpTickets.ResumeLayout();
            flpTickets.Visible = true;
        }
        private void AddCard(IReadOnlyList<Route> legs, DateTime date, int qty)
        {
            var card = new UcFlightCard();
            card.LoadData(legs, date, qty);
            card.BuyClicked += Card_BuyClicked;
            flpTickets.Controls.Add(card);
        }

        private void ApplyFilter()
        {
            flpTickets.SuspendLayout();
            flpTickets.Visible = false;
            bool wantDirect = chkDirect.Checked;
            foreach (var ctl in flpTickets.Controls.OfType<UcFlightCard>())
            {
                bool isDirect = ctl.Legs.Count == 1;
                ctl.Visible = wantDirect ? isDirect : !isDirect;
            }
            flpTickets.ResumeLayout();
            flpTickets.Invalidate();
            flpTickets.Visible = true;
        }

        private void Card_BuyClicked(object? sender, TicketInfo info)
        {

            var routesDesc = string.Join(" → ",
                 info.Legs.Select(r => r.Departure)
                 .Concat(new[] { info.Legs.Last().Arrival }));

            var message = new StringBuilder();
            message.AppendLine("Konfirmo blerjen e biletës me këto detaje:");
            message.AppendLine($"• Rruga      : {routesDesc}");
            message.AppendLine($"• Data       : {info.FlightDate:dd/MM/yyyy}");
            message.AppendLine($"• Klasa      : {info.SeatClass}");
            message.AppendLine($"• Sasia      : {info.Quantity}");
            message.AppendLine($"• Çmimi total: {info.Price:0} €");
            message.AppendLine();
            message.Append("Dëshiron ta vazhdosh?");

            if (MessageBox.Show(
                  message.ToString(),
                  "Përfundim Blerjeje",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question
                     ) != DialogResult.Yes)
                return;

            var firstLeg = info.Legs.First();
            int routeId = firstLeg.Id;

            var routeInDb = Program.DbContext.Routes.Find(routeId);
            if (routeInDb == null)
                throw new InvalidOperationException($"No Route with Id={routeId} found!");

            var ticket = new Bileta
            {
                RouteId = routeId,
                EmriPasagjerit = Session.CurrentUser.Username,
                DataRezervimit = DateTime.Now,
                Klasa = info.SeatClass,
                Statusi = "Ne Pritje",
                Fluturimi = string.Join(" → ",
                                    info.Legs
                                        .Select(r => r.Departure)
                                        .Concat(new[] { info.Legs.Last().Arrival }))
            };

            // Save it
            new TicketsManager().Add(ticket);

            MessageBox.Show("Biletë e blerë me sukses!");
            ClearForm();

           ShowSuggestedTickets();
        }
        private void ClearForm()
        {
            cbFrom.SelectedIndex = -1;
            cbTo.Items.Clear();
            cbTo.Items.AddRange(Airports);
            cbTo.SelectedIndex = -1;

            dtDepart.Value = DateTime.Today;
            //dtReturn.Value = DateTime.Today;

            rbOneWay.Checked = true;
            chkDirect.Checked = true;

            numPasangers.Value = numPasangers.Minimum;

            flpTickets.SuspendLayout();
            flpTickets.Controls.Clear();
            flpTickets.ResumeLayout();
        }
        private void cbFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFrom.SelectedIndex < 0) return;

            var departure = cbFrom.SelectedItem.ToString();
            cbTo.Items.Clear();
            foreach (var a in RouteDeafults.Airports)
                if (a != departure)
                    cbTo.Items.Add(a);
        }
        private void cbTo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void FrmBrowseFlights_Shown(object sender, EventArgs e)
        {
           ShowSuggestedTickets();
        }
        public void ShowSuggestedTickets()
        {
            flpTickets.SuspendLayout();
            flpTickets.Visible = false;
            flpTickets.Controls.Clear();

            var mgr = new RoutesManager();
            var today = DateTime.Today;

            var dayName = dtDepart.Value.DayOfWeek.ToString();

            //Tregon rruget qe jane diten e sotme
            //var all = mgr.GetAllRoutes()
            //    .Where(r => r.Status == "Aktiv" &&
            //                r.DepartureDay == dayName)
            //            .ToList();

            //Trego te gjithe rruget ne databaze
            var all = mgr.GetAllRoutes()
                .Where(r => r.Status == "Aktiv")
                        .ToList();

            var qty = (int)numPasangers.Value;

            //Fluturime direkte
            foreach (var d in all)
                AddCard(new[] { d }, today, qty);

            //Fluturime me nderrim
            foreach (var l1 in all)
                foreach (var l2 in all)
                {
                    if (l1.Arrival != l2.Departure) continue;
                    var gap = l2.StartTime - l1.EndTime;
                    if (gap < TimeSpan.Zero) gap += TimeSpan.FromDays(1);
                    if (gap < TimeSpan.FromMinutes(30)
                     || gap > TimeSpan.FromHours(5))
                        continue;
                    AddCard(new[] { l1, l2 }, today, qty);
                }

            if (flpTickets.Controls.Count == 0)
            {
                flpTickets.Controls.Add(new Label
                {
                    Text = "Nuk u gjet asnjë fluturim.",
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12, FontStyle.Italic)
                });
            }

            flpTickets.ResumeLayout();
            ApplyFilter();
            flpTickets.Visible = true;
            
        }
        private void dtDepart_ValueChanged(object sender, EventArgs e)
        {
            var minReturn = dtDepart.Value.Date.AddDays(1);

            dtReturn.MinDate = minReturn;
            dtReturn.Value = minReturn;
            dtReturn.Enabled = true;
        }

        private void chkDirect_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
            ShowSuggestedTickets();
        }
    }
}
