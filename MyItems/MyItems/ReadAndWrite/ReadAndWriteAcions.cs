using System.Linq;
using MyItems.Models;

namespace MyItems.ReadAndWrite
{
    public class ReadAndWriteAcions
    {
        private readonly ItemContext _itemContext = new ItemContext();

        public IQueryable<ItemModel> Read()
        {
            var result = _itemContext.Items;
            return result;
        }

        public ItemModel Write(ItemModel itemModel)
        {
            var result = _itemContext.Items.Add(itemModel);
            _itemContext.SaveChanges();
            return result;
        }
    }
}