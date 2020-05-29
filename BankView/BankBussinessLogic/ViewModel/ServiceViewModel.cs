using BankBussinessLogic.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BankBussinessLogic.ViewModel
{
    public class ServiceViewModel
    {
        public int Id { get; set; }
        public int WorkerId { get; set; }
        [DisplayName("ФИО сотрудника")]
        public string WorkerFIO { get; set; }
        [DisplayName("Вид услуги")]
        public string TypeService { get; set; }
        [DisplayName("Статус")]
        public Status Status { get; set; }
        public List<ServiceClientViewModel> ServiceClients { get; set; }
    }
}
