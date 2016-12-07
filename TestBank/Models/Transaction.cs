using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestBank.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Required]
        public DateTime Timestamp { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public int FromAccount { get; set; }
        [Required]
        public int ToAccount { get; set; }
    }
}