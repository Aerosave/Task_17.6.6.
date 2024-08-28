using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17.TypesAccount
{
    public class SalaryAccount : IAccount
    {
        public double Balance { get; set; }

        public double CalculateInterest()
        {
            return Balance * 0.5;
        }
    }
}
