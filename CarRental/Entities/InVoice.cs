using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities
{
    class InVoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }
        // Propriedades Calculadas:
        public double TotalPayment { get { return BasicPayment + Tax; } }

        public InVoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public override string ToString()
        {
            return "BasicPayment: " + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: " + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal Payment:" + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
