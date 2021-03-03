using System.Collections.Generic;

namespace BaristaAPI
{
    public interface IBeverage
    {
        List<string> Ingredients { get; }
        string CupType { get; }
    }

    class Espresso : IBeverage
    {
        public List<string> Ingredients => new List<string>()
    {
        "Base"
    };

        public string CupType => "Small";
    }

    class Latte : IBeverage
    {
        public List<string> Ingredients => new List<string>()
    {
        "Base",
        "Milk"
    };

        public string CupType => "Medium";
    }

    class Mocha : IBeverage
    {
        public List<string> Ingredients => new List<string>()
    {
        "Base",
        "Chocolate Syrup",
        "Milk"
    };

        public string CupType => "Medium";
    }
    class Americano : IBeverage
    {
        public List<string> Ingredients => new List<string>()
    {
        "Base",
        "Water"
    };

        public string CupType => "Large";
    }

    class Macchiato : IBeverage
    {
        public List<string> Ingredients => new List<string>()
    {
        "Base",
        "Milk foam"
    };

        public string CupType => "Medium";
    }

    class Cappuccino : IBeverage
    {
        public List<string> Ingredients => new List<string>()
    {
        "Base",
        "Milk",
        "Milk foam"
    };

        public string CupType => "Large";
    }
}