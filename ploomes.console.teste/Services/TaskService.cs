
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
    public class TaskService
    {

        public async Task<string> Create(Tasks task)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var json = JsonConvert.SerializeObject(task);
                    var data = new StringContent(json, Encoding.UTF8, "application/json");
                    data.Headers.Add("User-Key", HeaderConstants.UserKey);
                    var result = await client.PostAsync(HttpConstants.BaseUrlOdata + HttpConstants.TaskUrlOdata, data);
                    return await result.Content.ReadAsStringAsync();
                }
                catch (Exception e)
                {

                    throw e;

                }
            }
        }

        public static bool Finish(int id)
        {
            return true;
        }
    } 
}