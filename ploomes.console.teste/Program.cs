using ploomes.api.teste.Entidades;
using ploomes.api.teste.Services;
using System;
using System.Collections.Generic;

namespace ploomes.console.teste
{
    class Program
    {
        static void Main(string[] args)
        {
            PostTask();
            PostContact();
            Deal();
        }
        public static void PostContact()
        {
            OtherProperty otherProperty = new OtherProperty();
            otherProperty.FieldKey = "";
            otherProperty.IntegerValue = 1;
            otherProperty.StringValue = "";
            List<OtherProperty> otherProperties = new List<OtherProperty>();
            otherProperties.Add(otherProperty);

            Phones phones = new Phones();
            phones.TypeId = 0;
            phones.CountryId = 0;
            List<Phones> phonies = new List<Phones>();
            phonies.Add(phones);

            var contact = new Contact { Name = "Pessoa Nova", Neighborhood = "Pinheiros", CompanyId = 0, TypeId = 0, ZipCode = 0, OriginId = 0, StreetAddressNumber = "325",
                OtherProperties = otherProperties,
                Phones = phonies,
            };

            ContactService contactService = new ContactService();
            var result = contactService.Create(contact).Result;
            Console.WriteLine(result);
        }
        public static void PostTask()
        {
            OtherProperty otherProperty = new OtherProperty();
            otherProperty.FieldKey = "";
            otherProperty.IntegerValue = 1;
            otherProperty.StringValue = "";
            List<OtherProperty> otherProperties = new List<OtherProperty>();
            otherProperties.Add(otherProperty);


            var task = new Tasks { Title = "Consumo API", Description = "Teste Ploomes", ContactId = 0,
                OtherProperties = otherProperties, DateTime = DateTime.Now
            };

            TaskService taskService = new TaskService();
            var result = taskService.Create(task).Result;
            Console.WriteLine(result);
        }
        public static void Deal()
        {
            var deal = new Deals { Title = "Consumo API", Amount = 20, ContactId = 0, StageId = 0, };


            DealService dealService = new DealService();
            var result = dealService.Create(deal).Result;
            Console.WriteLine(result);
        }
        
    }
}

