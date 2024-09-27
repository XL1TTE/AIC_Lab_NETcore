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
        public DecanatDbContext() { }
        public DbSet<Student> Students { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionStringBuilder = new NpgsqlConnectionStringBuilder
            {
                Host = "localhost",
                Port = 5432,
                Database = "aicDecanat",
                Username = "postgres",
                Password = "Dsbuhsdf.gentdre1"
            };

            optionsBuilder.UseNpgsql(connectionStringBuilder.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasKey(x => x.Id);
            base.OnModelCreating(modelBuilder);
        }
    }
}
