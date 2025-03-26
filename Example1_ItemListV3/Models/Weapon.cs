using Example1_ItemList.Abstractions;

namespace Example1_ItemList.Models
{
    public class Weapon : NamedEntity
    {
        public string Name { get; set; }
        public int MiniumDamage { get; set; }
        public int MaxiumDamage { get; set; }
    }
}
