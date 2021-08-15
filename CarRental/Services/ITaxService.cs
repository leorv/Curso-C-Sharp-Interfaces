using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Services
{
    interface ITaxService
    {
        // A interface define apenas o contrato. Então é realmente só essa linha aqui.
        double Tax(double amount);
    }
}
