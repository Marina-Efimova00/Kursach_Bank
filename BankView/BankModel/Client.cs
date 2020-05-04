using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace BankModel
{
    [DataContract]
    public class Client
    {
        [DataMember]
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
        public int Number { get; set; }
        [DataMember]
        [Required]
        public DateTime ClientDate { get; set; }
        [ForeignKey("ClientPassportData")]
        public virtual List<ServiceClient> ServiseClients { get; set; }
        public virtual List<Score> Scores { get; set; }
    }
}
