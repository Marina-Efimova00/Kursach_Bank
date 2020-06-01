﻿using BankBussinessLogic.BindingModel;
using BankBussinessLogic.Enums;
using BankBussinessLogic.Interfaces;
using BankBussinessLogic.ViewModel;
using BankDatabaseImplement.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
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
                        WorkerId = Convert.ToInt32(elem.Element("WorkerId").Value),
                        //ClientId = Convert.ToInt32(elem.Element("ClientId").Value),
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
                    Service element = context.Services.FirstOrDefault(rec => rec.Id != service.Id);
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
                    //element.ClientId = service.ClientId;
                    element.TypeService = service.TypeService;
                    element.Status = service.Status;
                    context.SaveChanges();
                }
            }
        }
        public List<ServiceViewModel> Read(ServiceBindingModel model)
        {
            using (var context = new BankDatabase())
            {
                SaveToDatabase();
                return context.Services
                .Where(rec => model == null || rec.Id == model.Id)
                .Select(rec => new ServiceViewModel
                {
                    Id = rec.Id,
                    WorkerId = rec.WorkerId.Value,
                    //ClientId = rec.ClientId.Value,
                    TypeService = rec.TypeService,
                    Status = rec.Status,
                    WorkerFIO = rec.Worker.WorkerFIO
                })
                .ToList();
            }
        }
        public void CreateOrUpdate(ServiceBindingModel model)
        {
            using (var context = new BankDatabase())
            {
                Service element = context.Services.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    throw new Exception("Уже есть такой клиент");
                }
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
                //element.WorkerId = model.WorkerId;
                element.TypeService = model.TypeService;
                element.Status = model.Status;
                context.SaveChanges();
            }
        }
    }
}
