using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace BankDatabaseImplement.Model
{
    public class Worker
    {
        public int Id { get; set; }
        [Required]
        public string WorkerFIO { get; set; }
        public int Salary { get; set; }
        [ForeignKey("WorkerId")]
        public virtual List<Service> Serveces { get; set; }
    }
}
