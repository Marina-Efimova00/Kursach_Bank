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
    public class WorkerLogic : IWorkerLogic
    {
        private readonly string WorkerFileName = "C://Users//marin.LAPTOP-0TUFHPTU//source//repos//Kursach_Bank//BankView//data//Worker.xml";
        public List<Worker> Workers { get; set; }
        public WorkerLogic()
        {
            Workers = LoadWorkers();
        }
        private List<Worker> LoadWorkers()
        {
            var list = new List<Worker>();
            if (File.Exists(WorkerFileName))
            {
                XDocument xDocument = XDocument.Load(WorkerFileName);
                var xElements = xDocument.Root.Elements("Worker").ToList();
                foreach (var elem in xElements)
                {
                    list.Add(new Worker
                    {
                        Id = Convert.ToInt32(elem.Attribute("Id").Value),
                        WorkerFIO = elem.Element("WorkerFIO").Value,
                        Salary = Convert.ToInt32(elem.Element("Salary").Value),
                    });
                }
            }
            return list;
        }
        public void SaveToDatabase()
        {
            var workers = LoadWorkers();
            using (var context = new BankDatabase())
            {
                foreach (var worker in workers)
                {
                    Worker element = context.Workers.FirstOrDefault(rec => rec.Id == worker.Id);
                    if (element != null)
                    {
                        break;
                    }
                    else
                    {
                        element = new Worker();
                        context.Workers.Add(element);
                    }
                    element.WorkerFIO = worker.WorkerFIO;
                    element.Salary = worker.Salary;
                    context.SaveChanges();
                }
            }
        }
        public List<WorkerViewModel> Read(WorkerBindingModel model)
        {
            SaveToDatabase();
            using (var context = new BankDatabase())
            {
                return context.Workers
                .Where(rec => model == null || rec.Id == model.Id)
                .Select(rec => new WorkerViewModel
                {
                    Id = rec.Id,
                    WorkerFIO = rec.WorkerFIO,
                    Salary = rec.Salary
                })
                .ToList();
            }
        }
    }
}
