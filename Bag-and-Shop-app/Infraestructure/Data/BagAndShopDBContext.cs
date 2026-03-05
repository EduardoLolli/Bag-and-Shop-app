using Bag_and_Shop_app.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Bag_and_Shop_app.Infraestructure.Data
{
  public class BagAndShopDBContext : DbContext
  {
    public BagAndShopDBContext(DbContextOptions<BagAndShopDBContext> options) : base(options)
    {
    }
    public DbSet<Campaign> Campaigns { get; set; }
    public DbSet<SystemEntity> SystemEntities { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Store> Store { get; set; }
    public DbSet<SystemFields> systemFields { get; set; }

  }
}