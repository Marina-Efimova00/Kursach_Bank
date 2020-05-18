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
        [DisplayName("Вид услуги")]
        public string TypeService { get; set; }
        public List<ServiceViewModel> Service;
    }
}
