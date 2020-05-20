using System;
using System.Collections.Generic;
using System.Text;

namespace BankDatabaseImplement.Model
{
    public class ServiceClient
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int ClientId { get; set; }
        public virtual Service Service { get; set; }
        public virtual Client Client { get; set; }
    }
}
