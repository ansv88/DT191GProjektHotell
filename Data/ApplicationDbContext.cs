using DT191GProjektHotell.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DT191GProjektHotell.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
    {
    }

    public DbSet<RoomModel> Rooms { get; set; }
    public DbSet<BookingModel> Bookings { get; set; }
    public DbSet<CustomerModel> Customers { get; set; }
    public DbSet<ReviewModel> Reviews { get; set; }
    public DbSet<ContactModel> ContactMessages { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Seeda 8 standardrum (RoomId 1-8)
        for (int i = 1; i <= 8; i++)
        {
            modelBuilder.Entity<RoomModel>().HasData(
                new RoomModel
                {
                    RoomId = i,
                    RoomNumber = $"{i}",
                    RoomType = "Standardrum",
                    Capacity = 2,
                    Price = 500,
                    IsAvailable = true
                });
        }

        // Seeda 4 deluxerum (RoomId 9-12)
        for (int i = 9; i <= 12; i++)
        {
            modelBuilder.Entity<RoomModel>().HasData(
                new RoomModel
                {
                    RoomId = i,
                    RoomNumber = $"{i}",
                    RoomType = "Deluxerum",
                    Capacity = 2,
                    Price = 800,
                    IsAvailable = true
                });
        }

        // Seeda 4 familjerum (RoomId 13-16)
        for (int i = 13; i <= 16; i++)
        {
            modelBuilder.Entity<RoomModel>().HasData(
                new RoomModel
                {
                    RoomId = i,
                    RoomNumber = $"{i}",
                    RoomType = "Familjerum",
                    Capacity = 4,
                    Price = 1200,
                    IsAvailable = true
                });
        }
    }

}