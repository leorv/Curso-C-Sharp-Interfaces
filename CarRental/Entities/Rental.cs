using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities
{
    class Rental
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Vehicle Vehicle { get; set; }
        public InVoice Invoice { get; set; }

        public Rental(DateTime start, DateTime end, Vehicle vehicle)
        {
            Start = start;
            End = end;
            Vehicle = vehicle;
            // Isto abaixo não é necessário, a classe já faz isso, mas apenas para ficar didático...:
            Invoice = null;
        }
    }
}
