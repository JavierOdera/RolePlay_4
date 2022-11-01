namespace RoleplayGame.Items;
using System.Collections.Generic;

public class GuanteDePoder : IAttackItem
{
    List<IGema> gemas = new List<IGema>();
    public int Daño{get; set;} = 5;
    public int AttackPower {get;} // ponemos el poder de ataque
    public GuanteDePoder()          //Al encontrar gemas, debemos verificar que la misma no exista ya en la lista de gemas. Esto lo podriamos hacer en el main?
    {
        foreach (IGema gema in gemas)
        {
            Daño=Daño+20;
        }
    }
    
    public void AddGema(IGema gema)
    {
        if (!gemas.Contains(gema))
        {
            gemas.Add(gema);
        }                               //Capaz que podriamos agregar algo que diga que la gema ya esta en el inventario si se da el caso
    }
    
    public override string ToString()//ponemos lo que se escribira si llamamos al objeto
        {
            return "Guante de Poder";
        }
}