using BaristaApi;
using System.Collections.Generic;

public class FluentEspresso
{
    private int _water;
    private int _milk;
    private int _foamedMilk;
    private int _ChocolateSyrup;
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

    public FluentEspresso ChocolateSyrup(int amount)
    {
        _ChocolateSyrup += amount;
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

        if (_foamedMilk > 0)
        {
            if (_milk > 0)
            {
                return  CoffeeType.Cappuccino.ToString();
            }
            else
            {
                return  CoffeeType.Macchiato.ToString();
            }
        }

        if (_ChocolateSyrup > 0)
        {
            return  CoffeeType.Mocha.ToString();
        }

        if (_water > 0)
        {
            return CoffeeType.Americano.ToString();
        }

        if (_milk > 0)
        {
            return CoffeeType.Latte.ToString();
        }
        else
        {
            return CoffeeType.Espresso.ToString();
        }
    }
}