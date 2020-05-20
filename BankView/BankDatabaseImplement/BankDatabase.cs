using BankDatabaseImplement.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankDatabaseImplement
{
    public class BankDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-0TUFHPTU\SQLEXPRESS;Initial Catalog=BankDatabase;Integrated Security=True;MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Worker> Workers { set; get; }
        public virtual DbSet<Client> Clients { set; get; }
        public virtual DbSet<Service> Services { set; get; }
        public virtual DbSet<ServiceClient> ServiceClients { set; get; }
    }
}
