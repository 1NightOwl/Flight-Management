using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Core.Logic
{
    public static class ClassPriceManager
    {
        public static void UpdateClassPrice(
            string selectedPlaneType,
            string priceText,
            Label lblPlaneClasses,
            Label lblEconomy,
            Label lblBusiness,
            Label lblFirstClass
            )
        {
            if (!PlaneDeafults.planeTemplates.TryGetValue(selectedPlaneType, out var plane))
                return;


            if (!double.TryParse(priceText, out double basePrice))
                basePrice = 0;

            if (plane.HasClasses)
            {
                lblPlaneClasses.Text = $"🎫Klaset e avionit: {selectedPlaneType}";

                lblEconomy.Text = $"💺Economy: {basePrice}€";

                if (plane.BuisnessFactor > 0)
                {
                    lblBusiness.Visible = true;
                    lblBusiness.Text = $"💼 Klasa First: {basePrice * plane.BuisnessFactor}€";
                }
                else
                {
                    lblFirstClass.Visible = false;
                }
                

                if (plane.FirstClassFactor > 0)
                {
                    lblFirstClass.Visible = true;
                    lblFirstClass.Text = $"👑 Klasa First: {basePrice * plane.FirstClassFactor}€";
                }
                else
                {
                    lblFirstClass.Visible = false;
                }
            }
            else
            {
                lblFirstClass.Visible = false;
                lblBusiness.Visible = false;
                lblPlaneClasses.Text = "💺 Ky avion nuk ka ndarje klasash (vetëm Economy)";
                lblEconomy.Text = $"💺Economy: {basePrice}€";
            }
        }
    }
}
