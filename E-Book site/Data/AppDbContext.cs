namespace E_Book_site.Data
{
    using Microsoft.EntityFrameworkCore;
    using E_Book_site.Model;
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BooksLogs>()
                .HasIndex(bl => new { bl.UserId, bl.BookId })
                .IsUnique(); // Prevents duplicate user-book entries

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AboutTeamMember>()
                .HasOne(a => a.Users)
                .WithMany() // optional: .WithMany(u => u.AboutTeamMemberships)
                .HasForeignKey(a => a.UserId);
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<BooksLogs> BooksLogs { get; set; }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<AboutTeamMember> AboutTeam { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<Social> Social { get; set; }

    }
}
