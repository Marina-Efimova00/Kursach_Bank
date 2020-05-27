using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BankBussinessLogic.ViewModel
{
    public class ServiceClientViewModel
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int ClientId { get; set; }
        [DisplayName("ФИО клиента")]
        public string ClientFIO { get; set; }
        public int Count { get; set; }
    }
}
