using Microsoft.EntityFrameworkCore;
using Survey.Models;

namespace Survey.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<UserSurvey> Surveys { get; set; }
    }
}
