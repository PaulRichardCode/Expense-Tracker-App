﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker_App.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        //categoryId
        //foreign key
        public int CategoryId { get; set; }
        //navigation property
        public Category Category { get; set; }
        public int Amount { get; set; }

        [Column(TypeName = "nvarchar(75)")]
        public string? Note { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
    }
}
