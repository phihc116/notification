using Microsoft.EntityFrameworkCore;
using Notification.Entitites;

namespace Context
{
    public class DatabaseContext(DbContextOptions<DatabaseContext> options) : DbContext(options)
    {
        public DbSet<NotificationData> Notifications { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<NotificationData>().HasData(new NotificationData()
            {
                Id = 1,
                Title = "Bạn nhận được một thông báo",
            });
        }
    }
}
