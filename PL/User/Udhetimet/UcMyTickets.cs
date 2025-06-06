using FlightManagement.Core.Data.Entities;
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
    public partial class UcMyTickets : UserControl
    {
        private Bileta _ticket = null!;

        public event EventHandler<int>? CancelClicked;
        public UcMyTickets()
        {
            InitializeComponent();
            btnCancel.Click += (_, __) => OnCancel();
        }
        public void LoadData(Bileta ticket)
        {
            _ticket = ticket;

            var fullParts = ticket.Fluturimi
                .Split(new[] { '→' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim())
                .ToArray();

            var codeParts = fullParts
                .Select(fp => CodeOnly(fp))
                .ToArray();

            lblRoute.Text = string.Join(" → ", codeParts);

            lblDate.Text = ticket.DataRezervimit.ToString("dd/MM/yyyy");

            lblClass.Text = $"Classi: {ticket.Klasa}";

            lblStatusClass.Text = ticket.Statusi;

            if (lblStatusClass.Text == "Pranuar")
            {
                lblStatusClass.ForeColor = Color.LawnGreen;
            }
            else if (lblStatusClass.Text == "Anuluar")
            {
                lblStatusClass.ForeColor = Color.Red;
            }
            else
            {
                lblStatusClass.ForeColor = Color.Orange;
            }

            lblDate.Text = ticket.DataRezervimit.ToString("g");

            lblPrice.Text = $"€ {ticket.Price:0.00}";

            var fullArrival = fullParts.Length > 0 ? fullParts.Last() : "";
            var imageFileName = $"{fullArrival}.png";
            string imagePath = Path.Combine(
                Application.StartupPath,
                "Resources",
                imageFileName);

            if (File.Exists(imagePath))
            {
                pnlInformation.BackgroundImage = Image.FromFile(imagePath);
                pnlInformation.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pnlInformation.BackgroundImage = null;
            }
        }
        private static string CodeOnly(string fullName)
        {
            var open = fullName.LastIndexOf('(');
            var close = fullName.LastIndexOf(')');
            if (open >= 0 && close > open + 1)
                return fullName.Substring(open + 1, close - open - 1);
            return fullName.Split(' ')[0];
        }
        private void OnCancel()
        {
            CancelClicked?.Invoke(this, _ticket.Id);
        }
    }
}
