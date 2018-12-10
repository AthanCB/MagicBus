using System;
using MagicBus.Common.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicBus.DataAccess
{
    public class MagicContext : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            string _connectionString = $"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MagicBus;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(_connectionString);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<MagicTrip> MagicTrips { get; set; }
    }
}
