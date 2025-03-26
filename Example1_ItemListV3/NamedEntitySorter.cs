using Example1_ItemList.Abstractions;

namespace Example1_ItemList
{
    public class NamedEntitySorter
    {
        public IEnumerable<NamedEntity> OrderEntitiesAlphabetically(IEnumerable<NamedEntity> items)
            => items.OrderBy(x => x.Name);
    }
}