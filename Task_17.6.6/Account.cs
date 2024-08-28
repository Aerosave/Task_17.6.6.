using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17
{
    public class Account
    {
        public IAccount AccountType { get; set; }
        public double Balance
        {
            get => AccountType.Balance;
            set => AccountType.Balance = value;
        }
        public double Interest { get; set; }
    }
}
