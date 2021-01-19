using Newtonsoft.Json;
using ploomes.api.teste.Entidades;
using ploomes.api.teste.Services;
using ploomes.console.teste.Entities.Response;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ploomes.console.teste
{
    class Program
    {
        static void Main(string[] args)
        {
            var contact = PostContact();
            var deal = PostDeal(contact.Id);
            PostTask(contact.Id, deal.Id);
            Update(deal);            
        }
        public static ContactR PostContact()
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

            var contact = new Contact { Name = "Rodrigo", Neighborhood = "Interlargos", CompanyId = 0, TypeId = 0, ZipCode = 0, OriginId = 0, StreetAddressNumber = "325",
                OtherProperties = otherProperties,
                Phones = phonies,
            };

            ContactService contactService = new ContactService();
            var result = JsonConvert.DeserializeObject<ResponseContacts>(contactService.Create(contact).Result);
            Console.WriteLine($"Cliente '{result.Value.FirstOrDefault().Name}' criado em {result.Value.FirstOrDefault().CreateDate}");
            return result.Value.FirstOrDefault();
        }
        public static TasksR PostTask(int contactId, int dealId)
        {
            OtherProperty otherProperty = new OtherProperty();
            otherProperty.FieldKey = "";
            otherProperty.IntegerValue = 1;
            otherProperty.StringValue = "";
            List<OtherProperty> otherProperties = new List<OtherProperty>();
            otherProperties.Add(otherProperty);


            var task = new Tasks { Title = "Tarefa Rodrigo", Description = "Tarefa de teste Rodrigo", ContactId = contactId,
                OtherProperties = otherProperties, DealId = dealId, DateTime = DateTime.Now
            };

            TaskService taskService = new TaskService();
            var result = JsonConvert.DeserializeObject<ResponseTasks>(taskService.Create(task).Result);
            Console.WriteLine($"Tarefa '{result.Value.FirstOrDefault().Title}' criada com sucesso");
            return result.Value.FirstOrDefault();
        }
        public static Deals PostDeal(int contactId)
        {
            OtherProperty otherProperty = new OtherProperty();
            otherProperty.FieldKey = "";
            otherProperty.IntegerValue = 1;
            otherProperty.StringValue = "";
            List<OtherProperty> otherProperties = new List<OtherProperty>();
            otherProperties.Add(otherProperty);


            var deal = new Deals { Title = "Negociação Rodrigo", Amount = 20, ContactId = contactId, StageId = 0,
            OtherProperties = otherProperties,};
            

            DealService dealService = new DealService();
            var result = JsonConvert.DeserializeObject<ResponseDeals>(dealService.Create(deal).Result);
            deal.Id = result.Value.FirstOrDefault().Id;
            Console.WriteLine($"Negociação '{result.Value.FirstOrDefault().Title}' criada com sucesso");
            return deal;
        }
        public static Deals Update(Deals deals)
        { 
            DealService dealService = new DealService();
            var result = JsonConvert.DeserializeObject<ResponseDeals>(dealService.Update(deals).Result);
            Console.WriteLine($"Negociação '{result.Value.FirstOrDefault().Title}' Alterada com sucesso");
            return deals;
        }
    }
}

