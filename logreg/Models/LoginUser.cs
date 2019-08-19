using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace logreg.Models
{
    public class LoginUser
    {
        [Required]
        public string LoginEmail {get;set;}
        [Required]
        public string LoginPassword {get;set;}
    }
}