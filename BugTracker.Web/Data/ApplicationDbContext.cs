using BugTracker.Web.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BugTracker.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // This line says: "Create a table named 'Bugs' based on the Bug class"
        public DbSet<Bug> Bugs { get; set; }
    }
}