using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace RaceDayy.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUsers>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Optional: store enum as string
            builder.Entity<ApplicationUsers>()
                .Property(u => u.Gender)
                .HasConversion<string>()
                .HasMaxLength(20);
        }
    }
}
