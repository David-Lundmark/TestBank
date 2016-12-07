using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestBank.DataAccessLayer;
using TestBank.Models;

namespace TestBank.Repositories
{
    public class OwnerRepository
    {
        private BankContext context;

        public OwnerRepository()
        {
            context = new BankContext();
        }

        public Owner AddOwner()
        {
            Owner owner = new Owner();
            context.Owners.Add(owner);
            context.SaveChanges();
            return owner;
        }

        public Owner FindOwner(int id)
        {
            return context.Owners.Find(id);
        }
    }
}