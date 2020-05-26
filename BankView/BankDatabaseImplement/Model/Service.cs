using BankBussinessLogic.Enums;
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
        [DataMember]
        public int ClientId { get; set; }
        [DataMember]
        public Status Status { get; set; }
        public virtual Worker Worker { get; set; }
        public virtual List<ServiceClient> ServiseClients { get; set; }
    }
}
