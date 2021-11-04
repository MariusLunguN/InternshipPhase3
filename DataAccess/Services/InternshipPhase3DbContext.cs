using DataAccess.Models;
using System.Data.Entity;

namespace DataAccess.Services
{
    public class InternshipPhase3DbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public DbSet<SocialMedia> SocialMedia { get; set; }
    }
}
