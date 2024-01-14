using MicroRabbit.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Data.Context
{
    public class TransferDbContext : DbContext
    {
        public TransferDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TransferLog> TransferLogs { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TransferLog>().HasData(
                new TransferLog { Id = 1, FromAccount = 123, ToAccount = 456, TransferAmount = 100.50m },
                new TransferLog { Id = 2, FromAccount = 789, ToAccount = 321, TransferAmount = 50.75m }
                // Add more seed data as needed
            );
        }
    }
}
