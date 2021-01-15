using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class fonction
    {
        public static double calcul_interet(double capital, double taux)
        {
            double interet = capital * taux / 100;
            return interet;
        }
    }
}

