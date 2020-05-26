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
    public class ClientLogic : IClientLogic
    {
        public void CreateOrUpdate(ClientBindingModel model)
        {
            using (var context = new BankDatabase())
            {
                Client element = context.Clients.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    throw new Exception("Уже есть такой клиент");
                }
                if (model.Id.HasValue)
                {
                    element = context.Clients.FirstOrDefault(rec => rec.Id == model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                else
                {
                    element = new Client();
                    context.Clients.Add(element);
                }
                element.PassportData = model.PassportData;
                element.ClientFIO = model.ClientFIO;
                element.Gender = model.Gender;
                element.Job = model.Job;
                element.Number = model.Number;
                context.SaveChanges();
            }
        }
        public void Delete(ClientBindingModel model)
        {
            using (var context = new BankDatabase())
            {
                Client element = context.Clients.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Clients.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }
        public List<ClientViewModel> Read(ClientBindingModel model)
        {
            using (var context = new BankDatabase())
            {
                return context.Clients
                .Where(rec => model == null || rec.Id == model.Id)
                .Select(rec => new ClientViewModel
                {
                    Id = rec.Id,
                    PassportData = rec.PassportData,
                    ClientFIO = rec.ClientFIO,
                    Gender = rec.Gender,
                    Job = rec.Job,
                    Number = rec.Number
                })
                .ToList();
            }
        }
    }
}
