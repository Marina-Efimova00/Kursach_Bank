using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BankBussinessLogic.ViewModel
{
    public class WorkerViewModel
    {
        public int Id { get; set; }
        [DisplayName("ФИО")]
        public string WorkerFIO { get; set; }
    }
}
