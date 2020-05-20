using System;
using System.Collections.Generic;
using System.Text;

namespace BankBussinessLogic.BindingModel
{
    public class ClientBindingModel
    {
        public int Id { get; set; }
        public int PassportData { get; set; }
        public string ClientFIO { get; set; }
        public string Gender { get; set; }
        public string Job { get; set; }
        public int Number { get; set; }
    }
}
