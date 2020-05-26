using BankBussinessLogic.BindingModel;
using BankBussinessLogic.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankBussinessLogic.Interfaces
{
    public interface IServiceLogic
    {
        List<ServiceViewModel> Read(ServiceBindingModel model);
        void CreateOrUpdate(ServiceBindingModel model);
        void Delete(ServiceBindingModel model);
    }
}
