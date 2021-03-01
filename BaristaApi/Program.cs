using System;

namespace BaristaApi
{
    class Program
    {
        static void Main(string[] args)
        {

            FluentEspresso espresso = new FluentEspresso().AddWater(2000000).AddMilk(200000000).FoamMilk(20);
            Console.WriteLine(espresso.ToBeverage());
            /* pseudo-code
            Espresso espresso = new Espresso().AddWater(20).AddBeans(b => b.AmountInG = 5 && b.Sort = CoffeSorts.Robusta).ToBravage();
            //espresso is type of Espresso

            Latte latte = new Espresso().AddWater(20).AddBeans(b => b.AmountInG = 7 && b.Sort = CoffeSorts.Robusta).AddMilk().ToBravage();
            //latte is type of Latte
             */
        }
    }
}
