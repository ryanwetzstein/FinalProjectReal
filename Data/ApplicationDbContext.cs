using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<FinalProject.Models.Application> Application { get; set; } = default!;
        public DbSet<FinalProject.Models.DogProfile> DogProfile { get; set; } = default!;
        public DbSet<FinalProject.Models.User> User { get; set; } = default!;

    }
}
