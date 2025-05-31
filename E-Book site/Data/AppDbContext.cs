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
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<BooksLogs> BooksLogs { get; set; }

    }
}
