namespace RoleplayGame.Items
{
    public class Coraza : IDefenseItem
    {
        /// <summary>
        /// El poder de defensa.
        /// </summary>
        /// <value></value>
        public int DefensePower
        {
            get
            {
                return 10;
            }
        }

        public override string ToString()
        {
            return "Coraza";
        }
    }
}