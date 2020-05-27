using BankBussinessLogic.BindingModel;
using BankBussinessLogic.Interfaces;
using BankBussinessLogic.ViewModel;
using BankDatabaseImplement.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace BankDatabaseImplement.Implements
{
    public class ServiceLogic: IServiceLogic
    {
        private readonly string ServiceFileName = "C://Users//marin.LAPTOP-0TUFHPTU//source//repos//Kursach_Bank//BankView//data//Service.xml";
        public List<Service> Services { get; set; }
        public ServiceLogic()
        {
            Services = LoadServices();
        }
        private List<Service> LoadServices()
        {
            var list = new List<Service>();
            if (File.Exists(ServiceFileName))
            {
                XDocument xDocument = XDocument.Load(ServiceFileName);
                var xElements = xDocument.Root.Elements("Service").ToList();
                foreach (var elem in xElements)
                {
                    list.Add(new Service
                    {
                        Id = Convert.ToInt32(elem.Attribute("Id").Value),
                        TypeService = elem.Element("TypeService").Value,
                    });
                }
            }
            return list;
        }
        public void SaveToDatabase()
        {
            var services = LoadServices();
            using (var context = new BankDatabase())
            {
                foreach (var service in services)
                {
                    Service element = context.Services.FirstOrDefault(rec => rec.Id == service.Id);
                    if (element != null)
                    {
                        break;
                    }
                    else
                    {
                        element = new Service();
                        context.Services.Add(element);
                    }
                    element.TypeService = service.TypeService;
                    context.SaveChanges();
                }
            }
        }
        public List<ServiceViewModel> Read(ServiceBindingModel model)
        {
            SaveToDatabase();
            using (var context = new BankDatabase())
            {
                return context.Services
                .Where(rec => model == null || rec.Id == model.Id)
                .Select(rec => new ServiceViewModel
                {
                    Id = rec.Id,
                    TypeService = rec.TypeService,
                })
                .ToList();
            }
        }
        public void CreateOrUpdate(ServiceBindingModel model)
        {
            using (var context = new BankDatabase())
            {
                Service element;
                if (model.Id.HasValue)
                {
                    element = context.Services.FirstOrDefault(rec => rec.Id == model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                else
                {
                    element = new Service();
                    context.Services.Add(element);
                }
                element.TypeService = model.TypeService;
                context.SaveChanges();
            }
        }
        public void Delete(ServiceBindingModel model)
        {
            using (var context = new BankDatabase())
            {
                Service element = context.Services.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Services.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }
    }
}
