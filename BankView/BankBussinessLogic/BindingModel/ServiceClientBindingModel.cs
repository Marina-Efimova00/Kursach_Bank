using System;
using System.Collections.Generic;
using System.Text;

namespace BankBussinessLogic.BindingModel
{
    public class ServiceClientBindingModel
    {
        public int ServiceId { get; set;}
        public int ClientPassportData { get; set; }
        public List<ServiceClientBindingModel> ServiceClient;
    }
}
