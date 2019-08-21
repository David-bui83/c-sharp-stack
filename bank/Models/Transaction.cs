using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace bank.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId {get;set;}

        public int AccountId {get;set;}
        
        [Required(ErrorMessage="Transaction is required")]
        public decimal? Amount {get;set;}

        public Account Owner {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;

    }
}