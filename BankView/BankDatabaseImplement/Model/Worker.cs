using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace BankDatabaseImplement.Model
{
    [DataContract]
    public class Worker
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        [Required]
        public string WorkerFIO { get; set; }
        public int Salary { get; set; }
        public virtual List<Service> Serveces { get; set; }
    }
}
