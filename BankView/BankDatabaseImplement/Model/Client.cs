using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace BankDatabaseImplement.Model
{
    public class Client
    {
        public int Id { get; set; }
        [Required]
        public int PassportData { get; set; }
        [Required]
        public string ClientFIO { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Job { get; set; }
        [Required]
        public int Number { get; set; }
    }
}
