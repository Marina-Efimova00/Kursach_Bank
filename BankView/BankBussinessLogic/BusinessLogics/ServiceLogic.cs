using BankBussinessLogic.BindingModel;
using BankBussinessLogic.Enums;
using BankBussinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankBussinessLogic.BusinessLogics
{
    public class ServiceLogic
    {
        private readonly IServiceLogic serviceLogic;
        public ServiceLogic(IServiceLogic serviceLogic)
        {
            this.serviceLogic = serviceLogic;
        }
        public void Create(CreateBindingModel model)
        {
            serviceLogic.CreateOrUpdate(new ServiceBindingModel
            {
                WorkerId = model.WorkerId,
                ClientId = model.ClientId,
                TypeService = model.TypeService,
                Status = Status.Рассматривается
            });
        }
        public void TakeOrderInWork(ChangeStatusBindingModel model)
        {
            var service = serviceLogic.Read(new ServiceBindingModel
            {
                Id = model.ServiceId})?[0];
            if (service == null)
            {
                throw new Exception("Не найдена услуга");
            }
            if (service.Status != Status.Рассматривается)
            {
                throw new Exception("Заказ не в статусе \"Рассматривается\"");
            }
            serviceLogic.CreateOrUpdate(new ServiceBindingModel
            {
                Id = service.Id,
               // ClientId = service.ClientId,
                WorkerId = service.WorkerId,
                TypeService = service.TypeService,
                Status = Status.Выполняется
            });
        }
        public void FinishOrder(ChangeStatusBindingModel model)
        {
            var service = serviceLogic.Read(new ServiceBindingModel
            {
                Id = model.ServiceId})?[0];
            if (service == null)
            {
                throw new Exception("Не найдена услуга");
            }
            if (service.Status != Status.Выполняется)
            {
                throw new Exception("Заказ не в статусе \"Выполняется\"");
            }
            serviceLogic.CreateOrUpdate(new ServiceBindingModel
            {
                Id = service.Id,
                //ClientId = service.ClientId,
                WorkerId = service.WorkerId,
                TypeService = service.TypeService,
                Status = Status.Готово
            });
        }
    }
}
