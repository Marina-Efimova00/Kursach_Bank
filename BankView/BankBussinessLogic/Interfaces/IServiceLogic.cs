using BankBussinessLogic.BindingModel;
using BankBussinessLogic.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankBussinessLogic.Interfaces
{
    public interface IServiceLogic
    {
        List<ServiceViewModel> GetList();
        ServiceViewModel GetElement(int id);
        void AddElement(ServiceBindingModel model);
        void UpdElement(ServiceBindingModel model);
        void DelElement(int id);
    }
}
