using Inventories.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventories.Data
{
    public class InventoryDbContext : DbContext
    {
        public DbSet<StockItems> StockItems => this.Set<StockItems>();

        public InventoryDbContext(DbContextOptions<InventoryDbContext> options)
            : base(options)
        {
        }        
    }
}
