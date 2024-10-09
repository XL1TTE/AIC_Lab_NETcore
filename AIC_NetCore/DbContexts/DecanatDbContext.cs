using AIC_NetCore.Domain;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIC_NetCore.Persistance.DbContexts
{
    public class DecanatDbContext : DbContext
    {
        private readonly string _connectionString;
        public DecanatDbContext(string connectionString) { _connectionString = connectionString; }
        public DbSet<Student> Students { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            optionsBuilder.UseNpgsql(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasKey(x => x.Id);
            base.OnModelCreating(modelBuilder);
        }
    }
}
