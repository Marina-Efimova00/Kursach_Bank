using BankBussinessLogic.BindingModel;
using BankBussinessLogic.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankBussinessLogic.Interfaces
{
    public interface IClientLogic
    {
        List<ClientViewModel> GetList();
        ClientViewModel GetElement(int id);
        void AddElement(ClientBindingModel model);
        void UpdElement(ClientBindingModel model);
        void DelElement(int id);
    }
}
