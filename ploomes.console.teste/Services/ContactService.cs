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
    public  class ContactService
    {

        public  async Task<string> Create(Contact contact)
        {

            using (var client = new HttpClient())
            {
                try
                {
                    var json = JsonConvert.SerializeObject(contact);
                    var data = new StringContent(json, Encoding.UTF8, "application/json");
                    data.Headers.Add("User-Key", HeaderConstants.UserKey);
                    var result = await client.PostAsync(HttpConstants.BaseUrlOdata + HttpConstants.ContactUrlOdata, data);
                    return await result.Content.ReadAsStringAsync();
                }
                catch (Exception e)
                {

                    throw e;
                }
            }
        }
    }
}
