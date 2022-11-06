namespace RoleplayGame.Items;

public class Vishanti : IAttackItem
{
    Darkhold darkhold = new Darkhold();
    Magic magic = new Magic();
    public int AttackPower // Attack power of the Vishanti item
    {
        get
        {
            return darkhold.AttackPower + magic.AttackPower;
        }
    }
    
    public override string ToString()// String to show when created
    {
        return "Vishanti";
    }
}