using Banking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Banking.WebApi.Controllers
{
    public class TransctionController : ApiController
    {
        // GET api/<controller>
        public  IEnumerable<Transction> GetTransction()
        {
            var list = new List<Transction>
            {
                new Transction{Amount=122M,Description="Bill Pay Vodaphone",TransctionDate=DateTime.Now.AddDays(-2),Type="DR"},
                new Transction{Amount=1222M,Description="Bill Pay Domino",TransctionDate=DateTime.Now.AddDays(-7),Type="DR"},
                new Transction{Amount=1222M,Description="Bill Pay Domino",TransctionDate=DateTime.Now.AddDays(-10),Type="CR"},
            };

            return list;
        }

        
    }
}