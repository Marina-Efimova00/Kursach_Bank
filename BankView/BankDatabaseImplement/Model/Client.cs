using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace BankDatabaseImplement.Model
{
    [DataContract]
    public class Client
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        [Required]
        public int PassportData { get; set; }
        [DataMember]
        [Required]
        public string ClientFIO { get; set; }
        [DataMember]
        [Required]
        public string Gender { get; set; }
        [DataMember]
        [Required]
        public string Job { get; set; }
        [DataMember]
        [Required]
        public int Number { get; set; }
        [DataMember]
        public DateTime ClientDate { get; set; }
        [ForeignKey("ClientId")]
        public virtual List<ServiceClient> ServiseClients { get; set; }
    }
}
