using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SIMS.Model;

namespace SIMS.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<SIMS.Model.Semesters> Semesters { get; set; } = default!;
        public DbSet<SIMS.Model.Departments> Departments { get; set; } = default!;
        public DbSet<SIMS.Model.Majors> Majors { get; set; } = default!;
        public DbSet<SIMS.Model.Subjects> Subjects { get; set; } = default!;
        public DbSet<SIMS.Model.Courses> Courses { get; set; } = default!;
        public DbSet<ApplicationUser> ApplicationUser { get; set; } = default!;
    }
}
