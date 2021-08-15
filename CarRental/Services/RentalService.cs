using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Entities;

namespace CarRental.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }
        // Aqui fazendo uma dependência de forma inadequada, propositalmente, somente para depois a gente ver a melhor forma de fazer isso.
        private ITaxService _taxService;
        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInVoice(Rental rental)
        {
            TimeSpan duration = rental.End.Subtract(rental.Start);
            double basicPayment = 0.0;

            if (duration.TotalHours <= 12)
            {
                basicPayment = Math.Ceiling(duration.TotalHours) * PricePerHour;
            }
            else
            {
                basicPayment = Math.Ceiling(duration.TotalDays) * PricePerDay;
            }

            double tax = _taxService.Tax(basicPayment);

            rental.Invoice = new InVoice(basicPayment, tax);
        }
    }
}
