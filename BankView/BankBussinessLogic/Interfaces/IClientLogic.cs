using BankBussinessLogic.BindingModel;
using BankBussinessLogic.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankBussinessLogic.Interfaces
{
    public interface IClientLogic
    {
        List<ClientViewModel> Read(ClientBindingModel model);
        void CreateOrUpdate(ClientBindingModel model);
        void Delete(ClientBindingModel model);
    }
}
