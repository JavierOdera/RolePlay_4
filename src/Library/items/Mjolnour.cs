namespace RoleplayGame.Items;

public class Mjolnour : IAttackItem
{
    public int AttackPower // ponemos el poder de ataque
    {
        get
        {
            return 30;
        }
    }
    
    public override string ToString()//ponemos lo que se escribira si llamamos al objeto
        {
            return "Mjolnour";
        }
}