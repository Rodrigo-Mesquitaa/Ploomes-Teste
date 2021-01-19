using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ploomes.api.teste.Entidades
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Neighborhood { get; set; }
        public int ZipCode { get; set; }
        public int OriginId { get; set; }
        public object CompanyId { get; set; }
        public string StreetAddressNumber { get; set; }
        public int TypeId { get; set; }
        public DateTime CreateDate { get; set; }
        public List<Phones> Phones { get; set; }
        public List<OtherProperty> OtherProperties { get; set; }
    }
}