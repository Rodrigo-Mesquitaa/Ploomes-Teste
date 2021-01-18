using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ploomes.api.teste.Entidades
{
    public class Tasks
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
        public int ContactId { get; set; }
        public List<OtherProperty> OtherProperties { get; set; }
    }
}