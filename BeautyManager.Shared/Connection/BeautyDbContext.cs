using BeautyManager.Shared.Models.Db;
using BeautyManager.Shared.Models.Local;
using Microsoft.EntityFrameworkCore;

namespace BeautyManager.Shared.Connection;

public class BeautyDbContext : DbContext
{
    public DbSet<Models.Db.BeautyBook> BeautyBooks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseMySql("server=37.187.157.189;database=BeautyManager;user=root;password=MbVIJT7QR87i6PPV",
            ServerVersion.AutoDetect(
                "server=37.187.157.189;database=BeautyManager;user=root;password=MbVIJT7QR87i6PPV"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<BeautyTask>().HasData(
            new()
            {
                Id = 1,
                TaskTitle = "Man haircut",
                TaskDuration = new(1, 0)
            },
            new()
            {
                Id = 2,
                TaskTitle = "Man haircut + beard",
                TaskDuration = new(1, 30)
            },
            new()
            {
                Id = 3,
                TaskTitle = "Man beard",
                TaskDuration = new(0, 30)
            },
            new()
            {
                Id = 4,
                TaskTitle = "Woman haircut",
                TaskDuration = new(1, 30)
            },
            new()
            {
                Id = 5,
                TaskTitle = "Woman haircut + hair wash",
                TaskDuration = new(2, 0)
            }
        );
    }
}