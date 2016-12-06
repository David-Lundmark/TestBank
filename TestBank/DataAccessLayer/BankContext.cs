using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestBank.DataAccessLayer
{
    public class BankContext : DbContext
    {
        public BankContext() : base("DefaultConnection")
        {
        }

        public DbSet<Models.Owner> Owners { get; set; }
        public DbSet<Models.Account> Accounts { get; set; }
        public DbSet<Models.Transaction> Transactions { get; set; }
    }
}