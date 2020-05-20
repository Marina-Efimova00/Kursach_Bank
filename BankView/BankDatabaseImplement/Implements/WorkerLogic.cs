using BankBussinessLogic.BindingModel;
using BankBussinessLogic.Interfaces;
using BankBussinessLogic.ViewModel;
using BankDatabaseImplement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankDatabaseImplement.Implements
{
    public class WorkerLogic : IWorkerLogic
    {
        public void CreateOrUpdate(WorkerBindingModel model)
        {
            using (var context = new BankDatabase())
            {
                Worker element = context.Workers.FirstOrDefault(rec => rec.Id != model.Id);
                if (element != null)
                {
                    throw new Exception("Уже есть такой сотрудник");
                }
                if (model.Id.HasValue)
                {
                    element = context.Workers.FirstOrDefault(rec => rec.Id == model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                else
                {
                    element = new Worker();
                    context.Workers.Add(element);
                }
                element.WorkerFIO = model.WorkerFIO;
                context.SaveChanges(); 
            }
        }
        public void Delete(WorkerBindingModel model)
        {
            using (var context = new BankDatabase())
            {
                Worker element = context.Workers.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Workers.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }
        public List<WorkerViewModel> Read(WorkerBindingModel model)
        {
            using (var context = new BankDatabase())
            {
                return context.Workers
                .Where(rec => model == null || rec.Id == model.Id)
                .Select(rec => new WorkerViewModel
                {
                    Id = rec.Id,
                    WorkerFIO = rec.WorkerFIO
                })
                .ToList();
            }
        }
    }
}
