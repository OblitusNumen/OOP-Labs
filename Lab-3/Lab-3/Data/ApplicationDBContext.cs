using Lab_3.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab_3.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) {
            Database.EnsureCreated();
        }
        public DbSet<Lab_3.Models.University> University { get; set; } = default!;
        public DbSet<Lab_3.Models.Specialization> Specialization { get; set; } = default!;
        public DbSet<Lab_3.Models.UniversitySpecializations> UniversitySpecializations { get; set; } = default!;
        public DbSet<Lab_3.Models.Branch> Branch { get; set; } = default!;
    }
}
