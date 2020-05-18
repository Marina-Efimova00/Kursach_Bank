using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BankBussinessLogic.ViewModel
{
    public class ServiceClientViewModel
    {
        public int ServiceId { get; set; }
        public int ClientPassportData { get; set; }
        [DisplayName("Услуга")]
        public string TypeService { get; set; }
        [DisplayName("ФИО клиента")]
        public string ClientFIO { get; set; }
    }
}
