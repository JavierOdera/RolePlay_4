namespace RoleplayGame.Items;

public class Palo : IAttackItem
{
    public int AttackPower 
    {
        get
        {
            return 10;
        }
    }
    
    public override string ToString()//ponemos lo que se escribira si llamamos al objeto
        {
            return "Palo";
        }
}