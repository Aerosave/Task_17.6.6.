using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17
{
    public static class Calculator
    {
        public static void CalculateInterest(Account account)
        {
            account.Interest = account.AccountType.CalculateInterest();
        }
    }
}
