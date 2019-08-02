namespace Organizations.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CompaniesContext : DbContext
    {
        public DbSet<Founder> Founders { get; set; }
        public DbSet<Company> Companies { get; set; }
        public CompaniesContext()
            : base("DefaultConnection")//"CompaniesContext")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().HasMany(c => c.Founders)
                .WithMany(s => s.Companies)
                .Map(t => t.MapLeftKey("CompanyId")
                .MapRightKey("FounderId")
                .ToTable("CompanyFounder"));
        }
    }
}