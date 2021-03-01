using BaristaApi;
using System.Collections.Generic;

public class FluentEspresso
{
    private int _water;
    private int _milk;
    private int _foamedMilk;
    private List<Bean> _beans = new List<Bean>(); // Multiple beans can be used in the same beverage
    private bool isGrinded;
    public enum CoffeeType
    {
        Cappuccino,
        Americano,
        Espresso,
        Macchiato,
        Mocha,
        Latte
    }

    public FluentEspresso AddWater(int amount)
    {
        _water += amount;
        return this;
    }

    public FluentEspresso AddMilk(int amount)
    {
        _milk += amount;
        return this;
    }

    public FluentEspresso FoamMilk(int amount)
    {
        _foamedMilk += amount;
        return this;
    }

    public FluentEspresso AddBeans(Bean bean)
    {
        _beans.Add(bean);
        return this;
    }

    public FluentEspresso GrindBeans()
    {
        isGrinded = true;
        return this;
    }

    public string ToBeverage()
    {
        CoffeeType coffeeType;

        if (_foamedMilk > 0 && _milk > 0)
        {
            coffeeType = CoffeeType.Cappuccino;
        }
        else
        {
            coffeeType = CoffeeType.Macchiato;
        }


    }
}