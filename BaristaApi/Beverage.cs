using System.Collections.Generic;

public interface IBeverage
{
    List<string> Ingredients { get; }
    string CupType { get; }

    FluentEspresso.CoffeeType GetCoffeeType();
}

class Espresso : IBeverage
{
    public List<string> Ingredients => throw new System.NotImplementedException();

    public string CupType => throw new System.NotImplementedException();

    public FluentEspresso.CoffeeType GetCoffeeType()
    {
        throw new System.NotImplementedException();
    }
}

class Latte : IBeverage
{
    public List<string> Ingredients => throw new System.NotImplementedException();

    public string CupType => throw new System.NotImplementedException();
}

class Mocha : IBeverage
{
    public List<string> Ingredients => throw new System.NotImplementedException();

    public string CupType => throw new System.NotImplementedException();
}
class Americano : IBeverage
{
    public List<string> Ingredients => throw new System.NotImplementedException();

    public string CupType => throw new System.NotImplementedException();
}

class Macchiato : IBeverage
{
    public List<string> Ingredients => throw new System.NotImplementedException();

    public string CupType => throw new System.NotImplementedException();
}

class Cappuccino : IBeverage
{
    public List<string> Ingredients => throw new System.NotImplementedException();

    public string CupType => throw new System.NotImplementedException();
}