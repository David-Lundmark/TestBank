using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestBank.Models
{
    public class Account
    {
        public Account()
        {
            Transactions = new List<int>();
        }

        [Key]
        public int AccountI { get; set; }

        [Required]
        public decimal Balance { get; set; }
        [Required]
        public bool Locked { get; set; }

        [ForeignKey("OwnerId")]
        public virtual Owner Owner { get; set; }
        public virtual ICollection<int> Transactions { get; set; }
    }
}