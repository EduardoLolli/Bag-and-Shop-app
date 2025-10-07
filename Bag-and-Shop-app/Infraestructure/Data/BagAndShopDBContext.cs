using Bag_and_Shop_app.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Bag_and_Shop_app.Infraestructure.Data
{
    public class BagAndShopDBContext : DbContext
    {
        public BagAndShopDBContext(DbContextOptions<BagAndShopDBContext> options): base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
