using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection;

namespace Inquiry_System.Models
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<StatusHistory> StatusHistories { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Inquiry> Inquiries { get; set; }
        public DbSet<PlaneType> PlaneTypes { get; set; }
    }
}
