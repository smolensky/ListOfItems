using System.ComponentModel.DataAnnotations.Schema;

namespace MyItems.Models
{
    [Table("ItemList")]
    public class ItemModel
    {
        public int Id { get; set; }
        public string Item { get; set; }
    }
}