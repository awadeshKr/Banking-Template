using Banking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Services
{
    public class BalanceService
    {
        public Balance GetBalance()
        {
            return new Balance { Amount = 12000M };
        }
    }
}
