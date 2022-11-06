namespace RoleplayGame.Items;
using System.Collections.Generic;
using System;

public class GuanteDePoder : IAttackItem
{
    List<IGema> gemas = new List<IGema>();
    public int AttackPower {get;} = 5;
    public GuanteDePoder()          
    {
        foreach (IGema gema in gemas)
        {
            AttackPower=AttackPower+20;
        }
    }
    public void AddGema(IGema gema)
    {
        if (!gemas.Contains(gema))
        {
            gemas.Add(gema);
        }
        else
        {
            Console.WriteLine("Ya tienes esta gema");
        }            
    }
    public void RemoveGema(IGema gema)
    {
        if (gemas.Contains(gema))
        {
            gemas.Remove(gema);
        
        }
        else
        {
            Console.WriteLine("No tienes esa gema");
        }
    }
    
    public override string ToString()//ponemos lo que se escribira si llamamos al objeto
        {
            return "Guante de Poder";
        }
}