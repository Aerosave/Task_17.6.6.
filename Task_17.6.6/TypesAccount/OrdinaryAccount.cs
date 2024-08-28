using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17.TypesAccount
{
    public class OrdinaryAccount : IAccount
    {
        public double Balance { get; set; }

        public double CalculateInterest()
        {
            double interest = Balance * 0.4;

            if (Balance < 1000)
                interest -= Balance * 0.2;
            else if (Balance >= 1000)
                interest -= Balance * 0.4;

            return interest;
        }
    }

}
