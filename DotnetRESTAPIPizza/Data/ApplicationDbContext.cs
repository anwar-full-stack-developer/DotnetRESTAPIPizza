using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

using DotnetRESTAPIPizza.Models;

namespace DotnetRESTAPIPizza.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
// DbContextOptionsBuilder.EnableSensitiveDataLogging
        }


        public DbSet<Pizzaa> Pizzas { get; set; } = null!;

    }
}