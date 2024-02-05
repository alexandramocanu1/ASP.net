using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Planner.Models;
using System.Xml.Linq;

namespace Planner.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<TripModel> Trips { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Accomodation> Accomodations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserTripModel>()
                .HasKey(s => new { s.UserId, s.TripId });

            modelBuilder.Entity<UserTripModel>()
                .HasOne(comment => comment.User)
                .WithMany(user => user.Trips)
                .HasForeignKey(comment => comment.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<UserTripModel>()
                .HasOne(comment => comment.Trip)
                .WithMany(post => post.Trips)
                .HasForeignKey(comment => comment.TripId)
                .OnDelete(DeleteBehavior.Cascade);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("your_connection_string");
            }
        }
    }
}
