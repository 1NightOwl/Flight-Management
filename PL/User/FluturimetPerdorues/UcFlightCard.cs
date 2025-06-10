using FlightManagement.Core.Data.Entities;
using FlightManagement.Core.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightManagement.PL.User.FluturimetPerdorues
{
    public partial class UcFlightCard : UserControl
    {
        public IReadOnlyList<Route> Legs => _legs;
        private IReadOnlyList<Route> _legs = Array.Empty<Route>();
        private DateTime _date;
        private int _quantity = 1;
        private double _price;

        public event EventHandler<TicketInfo>? BuyClicked;
        public UcFlightCard()
        {
            InitializeComponent();
            cbClass.SelectedIndexChanged += (_, __) => UpdatePrice();
            btnBuy.Click += (_, __) => OnBuy();
        }

        public void LoadData(
                        IReadOnlyList<Route> legs,
                        DateTime flightDate,
                        int quantity = 1)
        {
            _legs = legs;
            _date = flightDate;
            _quantity = quantity;


            var airports = legs
                    .Select(r => CodeOnly(r.Departure))
                    .Concat(new[] { CodeOnly(legs.Last().Arrival) });

            lblRoute.Text = string.Join(" → ", airports);


            lblDate.Text = flightDate.ToString("ddd, dd MMM yyyy");
            lblTimes.Text = $"{legs.First().StartTime:hh\\:mm} – {legs.Last().EndTime:hh\\:mm}";

            int stops = legs.Count - 1;
            lblStops.Text = stops == 0 ? "Direct"
                           : stops == 1 ? "1 stop"
                           : $"{stops} stops";


            cbClass.Items.Clear();
            cbClass.Items.Add("Economy");
            if (legs.Any(r => r.Plane.HasClasses))
            {
                if (legs.Max(r => r.Plane.BuisnessFactor) > 0) cbClass.Items.Add("Business");
                if (legs.Max(r => r.Plane.FirstClassFactor) > 0) cbClass.Items.Add("First");
            }
            cbClass.Visible = cbClass.Items.Count > 1;
            cbClass.SelectedIndex = 0;

            pnlInformation.BackgroundImage = null;
            //marrja e emrit te imazhit qe do te vendoset per avionin e ri
            var imageFileName = legs.Last().Arrival + ".png";
            string imagePath = Path.Combine(Application.StartupPath, "Resources", imageFileName);

            //kontrollimi nese imazhi ekziston ose jo dhe vendosja e sakte e saje ne picture box
            if (File.Exists(imagePath))
            {
                pnlInformation.BackgroundImage = Image.FromFile(imagePath);
                pnlInformation.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pnlInformation.BackgroundImage = null;
                MessageBox.Show("Harta për këtë avion nuk u gjet.");
            }

            UpdatePrice();
        }

        public void SetQuantity(int qty)
        {
            _quantity = qty;
            UpdatePrice();
        }

        private void UpdatePrice()
        {
            if (_legs == null || !_legs.Any())
                return;

            double classFactor = cbClass.SelectedItem switch
            {
                "Business" => _legs.Max(r => r.Plane.BuisnessFactor),
                "First" => _legs.Max(r => r.Plane.FirstClassFactor),
                _ => 1
            };

            double baseSum = _legs.Sum(r => r.Price);

            _price = baseSum * classFactor * _quantity;
            lblPrice.Text = $"€ {_price:0}  ({_quantity}×)";
        }

        private static string CodeOnly(string fullName)
        {
            var open = fullName.LastIndexOf('(');
            var close = fullName.LastIndexOf(')');
            if (open >= 0 && close > open + 1)
                return fullName.Substring(open + 1, close - open - 1);
            return fullName.Split(' ')[0]; 
        }

        private void OnBuy()
        {
            BuyClicked?.Invoke(this, new TicketInfo
            {
                Legs = _legs,
                FlightDate = _date,
                SeatClass = cbClass.SelectedItem!.ToString()!,
                Price = _price,
                Quantity = _quantity
            });
        }

        private void UcFlightCard_Load(object sender, EventArgs e)
        {

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {

        }
    }
}
