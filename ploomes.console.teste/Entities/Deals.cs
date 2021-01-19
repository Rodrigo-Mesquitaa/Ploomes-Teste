using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ploomes.api.teste.Entidades
{
    public class Deals
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ContactId { get; set; }
        public int Amount { get; set; }
        public int StageId { get; set; }
        public List<OtherProperty> OtherProperties { get; set; }
    }
}