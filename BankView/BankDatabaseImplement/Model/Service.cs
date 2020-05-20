using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace BankDatabaseImplement.Model
{
    [DataContract]
    public class Service
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        [Required]
        public string TypeService { get; set; }
        [DataMember]
        public int WorkerId { get; set; }
        public virtual List<ServiceClient> ServiseClients { get; set; }
    }
}
