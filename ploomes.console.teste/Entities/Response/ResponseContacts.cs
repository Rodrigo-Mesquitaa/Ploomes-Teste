using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ploomes.console.teste.Entities.Response
{
    public class ResponseContacts
    {
        [JsonProperty("@odata.context")]
        public string OdataContext { get; set; }
        public List<ContactR> Value { get; set; }
    }
    public class ContactR
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
