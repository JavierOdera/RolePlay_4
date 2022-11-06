namespace RoleplayGame.Items;

public class Darkhold : IAttackItem
{
    public int AttackPower // Attack power of the Darkhold item
    {
        get
        {
            return 40;
        }
    }
    
    public override string ToString()// String to show when created
    {
        return "Darkhold";
    }
}