using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BankDatabaseImplement.Model
{
    [DataContract]
    public class ServiceClient
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int ServiceId { get; set; }
        [DataMember]
        public int ClientId { get; set; }
        public virtual Service Service { get; set; }
        public virtual Client Client { get; set; }
    }
}
