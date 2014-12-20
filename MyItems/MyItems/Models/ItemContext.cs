using System.Data.Entity;

namespace MyItems.Models
{
    public class ItemContext : DbContext
    {
        public DbSet<ItemModel> Items { get; set; } 
    }
}