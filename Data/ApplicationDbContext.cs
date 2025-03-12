using Microsoft.EntityFrameworkCore;
using ABA.CertificationTracker.Models;

namespace ABA.CertificationTracker.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Certification> Certifications { get; set; }
    }
}