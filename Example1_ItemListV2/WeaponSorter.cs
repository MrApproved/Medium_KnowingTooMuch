using Example1_ItemList.Models;

namespace Example1_ItemList
{
    public class WeaponSorter
    {
        public IEnumerable<Weapon> OrderWeaponsAlphabetically(IEnumerable<Weapon> weapons)
            => weapons.OrderBy(x => x.Name);
    }
}