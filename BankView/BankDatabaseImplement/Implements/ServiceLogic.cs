using BankBussinessLogic.BindingModel;
using BankBussinessLogic.Enums;
using BankBussinessLogic.Interfaces;
using BankBussinessLogic.ViewModel;
using BankDatabaseImplement.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace BankDatabaseImplement.Implements
{
    public class ServiceLogic : IServiceLogic
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
                        WorkerId = Convert.ToInt32(elem.Attribute("WorkerId").Value),
                        ClientId = Convert.ToInt32(elem.Attribute("ClientId").Value),
                        TypeService = elem.Element("TypeService").Value,
                        Status = (Status)Enum.Parse(typeof(Status), elem.Element("Status").Value),
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
                    element.WorkerId = service.WorkerId;
                    element.ClientId = service.ClientId;
                    element.TypeService = service.TypeService;
                    element.Status = service.Status;
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
                    WorkerId = rec.WorkerId,
                    ClientId = rec.ClientId,
                    TypeService = rec.TypeService,
                    WorkerFIO = rec.Worker.WorkerFIO,
                    Status = rec.Status,
                    ServiceClients = GetServiceClientViewModel(rec)

                })
                .ToList();
            }
        }
        public static List<ServiceClientViewModel> GetServiceClientViewModel(Service service)
        {
            using (var context = new BankDatabase())
            {
                var ServiceClients = context.ServiceClients
                    .Where(rec => rec.ServiceId == service.Id)
                    .Include(rec => rec.Client)
                    .Select(rec => new ServiceClientViewModel
                    {
                        Id = rec.Id,
                        ServiceId = rec.ServiceId,
                        ClientId = rec.ClientId,
                        Count = rec.Count
                    }).ToList();
                foreach (var client in ServiceClients)
                {
                    var clientData = context.Clients.Where(rec => rec.Id == client.ClientId).FirstOrDefault();
                    client.ClientFIO = clientData.ClientFIO;
                }
                return ServiceClients;
            }
        }
        public void CreateOrUpdate(ServiceBindingModel model)
        {
            using (var context = new BankDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        Service element = model.Id.HasValue ? null : new Service();
                        if (model.Id.HasValue)
                        {
                            element = context.Services.FirstOrDefault(rec => rec.Id == model.Id);
                            if (element == null)
                            {
                                throw new Exception("Элемент не найден");
                            }
                            element.WorkerId = model.WorkerId;
                            //element.ClientId = model.ClientId;
                            element.TypeService = model.TypeService;
                            element.Status = model.Status;
                            context.SaveChanges();
                        }
                        else
                        {
                            element.WorkerId = model.WorkerId;
                            element.TypeService = model.TypeService;
                            element.Status = model.Status;
                            context.Services.Add(element);
                            context.SaveChanges();
                            var groupClients = model.ServiceClients
                               .GroupBy(rec => rec.ClientId)
                               .Select(rec => new
                               {
                                   ClientId = rec.Key,
                                   Count = rec.Sum(r => r.Count)
                               });

                            foreach (var groupClient in groupClients)
                            {
                                context.ServiceClients.Add(new ServiceClient
                                {
                                    ServiceId = element.Id,
                                    ClientId = groupClient.ClientId,
                                    Count = groupClient.Count
                                });
                                context.SaveChanges();
                            }
                        }
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
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
