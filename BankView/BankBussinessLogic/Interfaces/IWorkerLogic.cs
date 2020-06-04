using BankBussinessLogic.BindingModel;
using BankBussinessLogic.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankBussinessLogic.Interfaces
{
    public interface IWorkerLogic
    {
        List<WorkerViewModel> Read(WorkerBindingModel model);
        void CreateOrUpdate(WorkerBindingModel model);
    }
}
