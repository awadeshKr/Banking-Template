using Banking.Models;
using Plugin.RestClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = MainAsync(args).GetAwaiter().GetResult();

            var i = 10;
           
        }

        static async Task<List<Transction>> MainAsync(string[] args)
        {
            RestClient<Transction> restClient = new RestClient<Transction>();
            var transctionList = await restClient.GetAsync();
            return transctionList;
        }
    }
}
