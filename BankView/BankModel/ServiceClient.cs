using System;
using System.Collections.Generic;
using System.Text;

namespace BankModel
{
    public class ServiceClient
    {
        public int ServiceId { get; set; }
        public int ClientPassportData { get; set; }
        public virtual Service Service { get; set; }
        public virtual Client Client { get; set; }
    }
}
