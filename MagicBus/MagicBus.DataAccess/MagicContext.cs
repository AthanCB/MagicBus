using System;
using MagicBus.Common.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MagicBus.DataAccess
{
    public class MagicContext : IdentityDbContext<ApplicationUser>
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            string _connectionString = $"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MagicBus;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(_connectionString);
        }
        public DbSet<User> AppUsers { get; set; }
        public DbSet<MagicTrip> MagicTrips { get; set; }
    }
}
