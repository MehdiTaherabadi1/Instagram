using CleanArch.Domin.Modals;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infra.Data.Context
{
    public class InstagramDBContext : DbContext
    {
        #region constrctor

        public InstagramDBContext(DbContextOptions<InstagramDBContext> options) :base(options)
        {
            
        }

        #endregion

        public DbSet<Course> Courses { get; set; }
    }
}