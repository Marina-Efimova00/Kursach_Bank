using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace BankModel
{
    [DataContract]
    public class Worker
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        [Required]
        public string WorkerFIO { get; set; }
        [DataMember]
        public int NumberOfClients { get; set; }
        [DataMember]
        public int TotalNumberOfService { get; set; }
        [DataMember]
        public decimal Salary { get; set; }
        [ForeignKey("WorkerId")]
        public virtual List<Service> Serveces { get; set; }
    }
}
