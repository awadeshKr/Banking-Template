using Banking.Models;
using Plugin.RestClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Services
{
    public class TransctionService
    {
        public async Task<List<Transction>> GetTransctionsAsync()
        {
            //var transctionList = new List<Transction>
            //{
            //    new Transction{Amount=122M,Description="Bill Pay Vodaphone",TransctionDate=DateTime.Now.AddDays(-2),Type="DR"},
            //    new Transction{Amount=1222M,Description="Bill Pay Domino",TransctionDate=DateTime.Now.AddDays(-5),Type="DR"},
            //    new Transction{Amount=1222M,Description="Bill Pay Domino",TransctionDate=DateTime.Now.AddDays(-5),Type="DR"},
            //};
            RestClient<Transction> restClient = new RestClient<Transction>();
            var transctionList = await restClient.GetAsync();
            return transctionList;
        }
    }
}
