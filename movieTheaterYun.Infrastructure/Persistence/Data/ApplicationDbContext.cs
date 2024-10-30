using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using movieTheaterYun.Domain.Entities.Bookings;
using movieTheaterYun.Domain.Entities.Discounts;
using movieTheaterYun.Domain.Entities.Halls;
using movieTheaterYun.Domain.Entities.Movies;
using movieTheaterYun.Domain.Entities.Showtimes;
using movieTheaterYun.Domain.Entities.Snacks;
using movieTheaterYun.Domain.Entities.Tickets;
using movieTheaterYun.Domain.Entities.Users;
namespace movieTheaterYun.Infrastructure.Persistence.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Showtime> Showtimes { get; set; }
        public DbSet<Snack> Snacks { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Booking>()
            .HasOne(b => b.Discount)
            .WithMany(d => d.Bookings) // Thay đổi ở đây
            .HasForeignKey(b => b.DiscountId); // Chỉ định khóa ngoại

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
