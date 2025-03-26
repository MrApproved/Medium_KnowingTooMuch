using Example1_ItemList.Models;

namespace Example1_ItemList
{
    public class Program
    {
        static void Main(string[] args)
        {
            var namedEntitySorter = new NamedEntitySorter();

            var items = new List<Item>
            {
                new Item() { Name = "Potion" },
                new Item() { Name = "Food" },
                new Item() { Name = "Rune" }
            };

            foreach (var item in namedEntitySorter.OrderEntitiesAlphabetically(items))
                Console.WriteLine(item.Name);

            var weapons = new List<Weapon>
            {
                new Weapon() { Name = "Sword" },
                new Weapon() { Name = "Axe" },
                new Weapon() { Name = "Dagger" }
            };

            foreach (var weapon in namedEntitySorter.OrderEntitiesAlphabetically(weapons))
                Console.WriteLine(weapon.Name);
        }
    }
}