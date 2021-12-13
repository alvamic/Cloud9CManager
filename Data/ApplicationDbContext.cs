using C9_CostManager.Models;
using Microsoft.EntityFrameworkCore;

namespace C9_CostManager.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<TripModel> Trips { get; set; }
        public DbSet<TripMemberModel> Members { get; set; }
        public DbSet<CostModel> Costs { get; set; }






        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CostModel>().Property(p => p.CostAmount).HasColumnType("decimal(18,4)");

        }
    }
}
