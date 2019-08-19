using System;
using Microsoft.EntityFrameworkCore;

namespace crudelicious.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) {}

        public DbSet<Recipe> Recipes {get;set;}
    }
}