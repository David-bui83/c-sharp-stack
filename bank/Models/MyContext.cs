using Microsoft.EntityFrameworkCore;
namespace bank.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options){}

        public DbSet<Account> Accounts {get;set;}
        public DbSet<Transaction> Transactions {get;set;}
    }
}