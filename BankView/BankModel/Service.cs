using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace BankModel
{
    [DataContract]
    public class Service
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        [Required]
        public string TypeService{ get; set; }
        [DataMember]
        [Required]
        public int WorkerId { get; set; }
        public virtual Worker Worker { get; set; }
        [ForeignKey("ServiceId")]
        public virtual List<ServiceClient> ServiseClients { get; set; }
    }
}
