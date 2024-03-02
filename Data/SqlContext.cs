using CrudApi.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace CrudApi.Data
{
    public class SqlContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
            Database.EnsureCreated();
            //Database.Migrate();
        }
    }
}
