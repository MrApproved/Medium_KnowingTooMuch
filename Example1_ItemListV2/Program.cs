using Example1_ItemList.Models;

namespace Example1_ItemList
{
    public class Program
    {
        static void Main(string[] args)
        {
            var items = new List<Item>
            {
                new Item() { Name = "Potion" },
                new Item() { Name = "Food" },
                new Item() { Name = "Rune" }
            };

            var itemSorter = new ItemSorter();

            foreach (var item in itemSorter.OrderItemsAlphabetically(items))
                Console.WriteLine(item.Name);

            var weapons = new List<Weapon>
            {
                new Weapon() { Name = "Sword" },
                new Weapon() { Name = "Axe" },
                new Weapon() { Name = "Dagger" }
            };

            var weaponSorter = new WeaponSorter();

            foreach (var weapon in weaponSorter.OrderWeaponsAlphabetically(weapons))
                Console.WriteLine(weapon.Name);
        }
    }
}