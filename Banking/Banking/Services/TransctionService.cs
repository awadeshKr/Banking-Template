using Banking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Services
{
    public class TransctionService
    {
        public List<Transction> GetTransctions()
        {
            var list = new List<Transction>
            {
                new Transction{Amount=122M,Description="Bill Pay Vodaphone",TransctionDate=DateTime.Now.AddDays(-2),Type="DR"},
                new Transction{Amount=1222M,Description="Bill Pay Domino",TransctionDate=DateTime.Now.AddDays(-5),Type="DR"},
                new Transction{Amount=1222M,Description="Bill Pay Domino",TransctionDate=DateTime.Now.AddDays(-5),Type="DR"},
            };

            return list;
        }
    }
}
