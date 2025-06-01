using FlightManagement.Core;
using FlightManagement.Core.Data.Entities;
using FlightManagement.Core.Logic.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightManagement.PL.User.Udhetimet
{
    public partial class FrmMyTickets : Form
    {
        private readonly TicketsManager _ticketsManager = new TicketsManager();
        public FrmMyTickets()
        {
            InitializeComponent();
        }

        private void FrmMyTickets_Shown(object sender, EventArgs e)
        {
            LoadUserTickets();
        }

        private void LoadUserTickets()
        {
            flpTickets.SuspendLayout();
            flpTickets.Visible = false;
            flpTickets.Controls.Clear();


            var userId = Session.CurrentUser.Id;
            List<Bileta> tickets = _ticketsManager.GetByUserId(userId);

            if (!tickets.Any())
            {
                flpTickets.Controls.Add(new Label
                {
                    Text = "S’ke asnjë biletë të rezervuar.",
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12, FontStyle.Italic)
                });
            }
            else
            {
                foreach (var ticket in tickets)
                {
                    var card = new UcMyTickets();
                    card.LoadData(ticket);
                    card.CancelClicked += Card_CancelClicked;
                    flpTickets.Controls.Add(card);
                }
            }

            lblTicketCount.Text = $"🎫 Ju keni {tickets.Count} bileta aktive";
            lblTotalPrice.Text = $"💰 Totali i shpenzuar: € {tickets.Sum(t => t.Price):0.00}";

            flpTickets.ResumeLayout();

            flpTickets.Visible = true;
        }

        private void Card_CancelClicked(object? sender, int ticketId)
        {
            if (MessageBox.Show(
                    "Jeni të sigurt që doni ta anuloni këtë biletë?",
                    "Konfirmo Anullimin",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                ) != DialogResult.Yes)
            {
                return;
            }

            _ticketsManager.Delete(ticketId);

            LoadUserTickets();
        }
    }
}
