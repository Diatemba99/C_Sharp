using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class fonction
    {
        public static double cal_interest(double capital, double taux)
        {
            double interest = capital * taux / 100;
            return interest;
        }
    }
}

