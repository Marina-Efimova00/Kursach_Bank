using BankBussinessLogic.BindingModel;
using BankBussinessLogic.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankBussinessLogic.Interfaces
{
    public interface IWorkerLogic
    {
        List<WorkerViewModel> GetList();
        WorkerViewModel GetElement(int id);
        void AddElement(WorkerBindingModel model);
        void UpdElement(WorkerBindingModel model);
        void DelElement(int id);
    }
}
