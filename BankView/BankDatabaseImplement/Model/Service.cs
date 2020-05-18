using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BankDatabaseImplement.Model
{
    public class Service
    {
        public int Id { get; set; }

        [Required]
        public string TypeService { get; set; }
        public int WorkerId { get; set; }
        public virtual Worker Worker { get; set; }
        [ForeignKey("ServiceId")]
        public virtual List<ServiceClient> ServiseClients { get; set; }
    }
}
