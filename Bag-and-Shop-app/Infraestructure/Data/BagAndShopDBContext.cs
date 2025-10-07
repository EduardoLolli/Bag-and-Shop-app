using Microsoft.EntityFrameworkCore;
namespace Bag_and_Shop_app.Infraestructure.Data
{
    public class BagAndShopDBContext : DbContext
    {
        public BagAndShopDBContext(DbContextOptions<BagAndShopDBContext> options): base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
