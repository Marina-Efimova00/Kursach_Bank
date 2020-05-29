using BankBussinessLogic.BindingModel;
using BankBussinessLogic.Enums;
using BankBussinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankBussinessLogic.BusinessLogics
{
    public class Mainlogic
    {
        private readonly IServiceLogic serviceLogic;
        public Mainlogic(IServiceLogic orderLogic)
        {
            this.serviceLogic = orderLogic;
        }
        public void Create(ServiceBindingModel model)
        {
            serviceLogic.CreateOrUpdate(new ServiceBindingModel
            {
                WorkerId = model.WorkerId,
                TypeService = model.TypeService,
                Status = model.Status
            });
        }
    }
}
