using Library.Web.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library.Web.Infrastructure
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<BookLending> BookLendings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Book
            modelBuilder.Entity<Book>()
                .HasKey(x => x.BookId);
            modelBuilder.Entity<Book>()
                .HasOne(x => x.Owner)
                .WithMany(x => x.Books)
                .HasForeignKey(x => x.OwnerId);

            // User 
            modelBuilder.Entity<User>()
                .HasKey(x => x.UserId);

            // BookLending
            modelBuilder.Entity<BookLending>()
                .HasKey(x => x.BookLendingId);
            modelBuilder.Entity<BookLending>()
                .HasOne(x => x.Owner)
                .WithMany(x => x.BookLendings)
                .HasForeignKey(x => x.OwnerId);
            modelBuilder.Entity<BookLending>()
                .HasOne(x => x.Book)
                .WithMany(x => x.BookLendings)
                .HasForeignKey(x => x.BookId);
        }
    }
}
