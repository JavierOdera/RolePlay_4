namespace RoleplayGame.Items
{
    /// <summary>
    /// Tipos de elementos
    /// </summary>
    public enum ItemType
    {
        Magic = 1,
        Robes = 2,
        Vishanti = 3,
        Darkhold = 4,
        Mjolnour = 5,
        GuanteDePoder = 6,
    }

    /// <summary>
    /// Creador de elementos. 
    /// </summary>
    public class ItemFactory
    {
        /// <summary>
        /// Permite crear elementos dado un tipo de elemento.
        /// </summary>
        /// <param name="type">El tipo de elemento</param>
        /// <returns>El elemento</returns>
        public static IItem GetItem(ItemType type)
        {
            switch (type)
            {
                case ItemType.Magic: return new Magic();
                case ItemType.Robes: return new Robes();
                case ItemType.Vishanti: return new Vishanti();
                case ItemType.Darkhold: return new Darkhold();
                case ItemType.Mjolnour: return new Mjolnour();
                case ItemType.GuanteDePoder: return new GuanteDePoder();

                default: return null;
            }
        }
    }
}