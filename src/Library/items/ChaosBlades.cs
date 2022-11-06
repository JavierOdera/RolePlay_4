namespace RoleplayGame.Items;

public class TablaCosmica : IAttackItem
{
    public int AttackPower // Attack power of the Tabla Cosmica item
    {
        get
        {
            return 35;
        }
    }
    
    public override string ToString()// String to show when created
    {
        return "Tabla Cosmica";
    }
}