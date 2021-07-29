using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace backEnd.Models
{
    public class DataContext : DbContext
    {
        public DataContext() { }
        public DataContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookBorrowingRequest>().HasOne(r => r.Detail).WithOne(d => d.Request);
            modelBuilder.Entity<User>().HasMany(u => u.Requests).WithOne(r => r.User);
            modelBuilder.Entity<BookBorrowingRequestDetail>().HasMany(d => d.Books).WithOne(b => b.Detail);
            modelBuilder.Entity<Category>().HasMany(c => c.Books).WithOne(b => b.Category);

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = 1,
                CategoryName = "Action",
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                UserId = 1,
                Name = "Admin",
                Password = "admin",
                _isAdmin = true
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                UserId = 2,
                Name = "D2efault",
                Password = "123qwe"
            });
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<BookBorrowingRequest> BookBorrowingRequests { get; set; }
        public DbSet<BookBorrowingRequestDetail> BookBorrowingRequestDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}