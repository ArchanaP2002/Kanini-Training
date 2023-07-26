//using Microsoft.EntityFrameworkCore;
//using BookStoreApi.Models;
//using BookStoreApi.models;

//namespace BookStoreApi.Data
//{
//    public class BookStoreContext : DbContext
//    {
//        public BookStoreContext(DbContextOptions<BookStoreContext> options)
//            : base(options)
//        {
//        }

//        public DbSet<Book> Books { get; set; }
//        public DbSet<Author> Authors { get; set; }
//        public DbSet<BookAuthors> BookAuthors { get; set; }
//        public DbSet<Publisher> Publishers { get; set; }
//        public DbSet<AuthorContact> AuthorContacts { get; set; }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<BookAuthors>()
//                .HasKey(ba => new { ba.BookId, ba.AuthorId });

//            modelBuilder.Entity<BookAuthors>()
//                .HasOne(ba => ba.Book)
//                .WithMany(b => b.BookAuthors)
//                .HasForeignKey(ba => ba.BookId);

//            modelBuilder.Entity<BookAuthors>()
//                .HasOne(ba => ba.Author)
//                .WithMany(a => a.BookAuthors)
//                .HasForeignKey(ba => ba.AuthorId);
//        }
//    }
//}

using BookStoreApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApi.Data
{
    //    public class BookStoreContext : DbContext
    //    {
    //        public BookStoreContext(DbContextOptions<BookStoreContext> options)
    //            : base(options)
    //        {
    //        }

    //        public DbSet<Author> Authors { get; set; }
    //        public DbSet<AuthorContact> AuthorContacts { get; set; }
    //        public DbSet<Book> Books { get; set; }
    //        public DbSet<BookAuthors> BookAuthors { get; set; }
    //        public DbSet<BookCategory> BookCategories { get; set; }
    //        public DbSet<Publisher> Publishers { get; set; }

    //        protected override void OnModelCreating(ModelBuilder modelBuilder)
    //        {
    //            modelBuilder.Entity<BookAuthors>()
    //                .HasKey(ba => new { ba.BookId, ba.AuthorId });

    //            modelBuilder.Entity<BookAuthors>()
    //                .HasOne(ba => ba.Book)
    //                .WithMany(b => b.BookAuthors)
    //                .HasForeignKey(ba => ba.BookId);

    //            modelBuilder.Entity<BookAuthors>()
    //                .HasOne(ba => ba.Author)
    //                .WithMany(a => a.BookAuthors)
    //                .HasForeignKey(ba => ba.AuthorId);
    //        }
    //    }
    //}


    public class BookStoreContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorContact> AuthorContacts { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookAuthors> BookAuthors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "your_connection_string";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}

