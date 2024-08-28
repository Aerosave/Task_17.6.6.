using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17
{
    public interface IAccount
    {
        double Balance { get; set; }
        double CalculateInterest();
    }
}

