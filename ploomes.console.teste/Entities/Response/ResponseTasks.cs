using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ploomes.console.teste.Entities.Response
{
    class ResponseTasks
    {
        [JsonProperty("@odata.context")]
        public string OdataContext { get; set; }
        public List<TasksR> Value { get; set; }
    }
    public class TasksR
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }

}
