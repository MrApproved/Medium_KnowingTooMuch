using Example1_ItemList.Models;

namespace Example1_ItemList
{
    public class ItemSorter
    {
        public IEnumerable<Item> OrderItemsAlphabetically(IEnumerable<Item> items)
            => items.OrderBy(x => x.Name);
    }
}