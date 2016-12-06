using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestBank.Models
{
    public class Owner
    {
        public Owner()
        {
            Accounts = new List<Account>();
        }

        [Key]
        public int OwnerId { get; set; }

        [Required, MaxLength(30)]
        public string FirstName { get; set; }
        [Required, MaxLength(30)]
        public string LastName { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}