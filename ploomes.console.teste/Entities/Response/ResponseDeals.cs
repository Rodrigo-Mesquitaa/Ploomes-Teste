using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ploomes.console.teste.Entities.Response
{
    class ResponseDeals
    {
        [JsonProperty("@odata.context")]
        public string OdataContext { get; set; }
        public List<DealsR> Value { get; set; }
    }

    public class DealsR
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
