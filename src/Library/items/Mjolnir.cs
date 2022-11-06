namespace RoleplayGame.Items;

public class Mjolnir : IAttackItem
{
    public int AttackPower // Attack power of the Mjolnir item
    {
        get
        {
            return 30;
        }
    }
    
    public override string ToString()// String to show when created
        {
            return "Mjolnir";
        }
}