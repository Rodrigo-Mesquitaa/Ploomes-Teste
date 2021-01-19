using Newtonsoft.Json;
using ploomes.api.teste.Entidades;
using ploomes.console.teste.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ploomes.api.teste.Services
{
    public class DealService
    {

        public async Task<string> Create(Deals deal)
        {

            using (var client = new HttpClient())
            {
                try
                {
                    var json = JsonConvert.SerializeObject(deal);
                    var data = new StringContent(json, Encoding.UTF8, "application/json");
                    data.Headers.Add("User-Key", HeaderConstants.UserKey);
                    var result = await client.PostAsync(HttpConstants.BaseUrlOdata + HttpConstants.DealUrlOdata, data);
                    return await result.Content.ReadAsStringAsync();


                }
                catch (Exception e)
                {

                    throw e;
                }
            }
        }
        public async Task<string> Update(Deals deals)
        {

            using (var client = new HttpClient())
            {
                try
                {
                    deals.Amount = 15000;
                    var json = JsonConvert.SerializeObject(deals);
                    var data = new StringContent(json, Encoding.UTF8, "application/json");
                    data.Headers.Add("User-Key", HeaderConstants.UserKey);
                    var result = await client.PatchAsync($"{HttpConstants.BaseUrlOdata}{HttpConstants.DealUrlOdata}({deals.Id})", data);
                    return await result.Content.ReadAsStringAsync();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public bool Win(int id)
        {
            return false;
        }
    }
}
