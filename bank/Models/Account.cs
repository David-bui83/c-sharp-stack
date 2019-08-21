using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace bank.Models
{
    public class Account
    {
        [Key]
        public int AccountId {get;set;}

        [Required(ErrorMessage="First name is required")]
        [MinLength(2,ErrorMessage="First name must be 2 characters or more")]
        public string FirstName {get;set;}
        
        [Required(ErrorMessage="Last name is required")]
        [MinLength(2,ErrorMessage="Last name must be 2 characters or more")]
        public string LastName {get;set;}

        [Required(ErrorMessage="Email is required")]
        [EmailAddress]
        public string Email {get;set;}

        [Required(ErrorMessage="Password is required")]
        [MinLength(8,ErrorMessage="Password needs to be 8 character or longer")]public string Password {get;set;}
        
        [Required(ErrorMessage="Confirm Password is required")]
        [Compare("Password",ErrorMessage="Passwords do not match")]
        [NotMapped]
        public string Confirm {get;set;}

        public decimal Balance {get;set;} = 0;

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public List<Transaction> Transactions {get;set;}
    }
}