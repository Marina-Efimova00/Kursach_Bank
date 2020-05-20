using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BankDatabaseImplement.Model
{
    public class Worker
    {
        public int Id { get; set; }
        [Required]
        public int WorkerFIO { get; set; }
    }
}
