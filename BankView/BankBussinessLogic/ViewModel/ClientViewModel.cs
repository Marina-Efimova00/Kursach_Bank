using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BankBussinessLogic.ViewModel
{
    public class ClientViewModel
    {
        public int Id { get; set; } 
        [DisplayName("ФИО")]
        public string ClientFIO { get; set; }
        [DisplayName("Пол")]
        public string Gender { get; set; }
        [DisplayName("Работа")]
        public string Job { get; set; }
        [DisplayName("Паспортные данные")]
        public int PassportData { get; set; }
        [DisplayName("Номер телефона")]
        public int Number { get; set; }
    }
}
