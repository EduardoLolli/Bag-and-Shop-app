using Bag_and_Shop_app.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Bag_and_Shop_app.Infraestructure.Data
{
    public class BagAndShopDBContext : DbContext
    {
        public BagAndShopDBContext(DbContextOptions<BagAndShopDBContext> options) : base(options)
        {
        }
        public DbSet<Bag> Bags { get; set; }
        public DbSet<BagItem> BagItems { get; set; }
        public DbSet<Body> Bodys { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemAtribute> ItemAtributes { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<StoreItem> StoreItems { get; set; }
        public DbSet<SystemEntity> SystemEntities { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
