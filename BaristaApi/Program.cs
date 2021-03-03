using System;

namespace BaristaApi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FluentEspresso beverage = new FluentEspresso().AddWater(25, 85).AddBeans(new Bean(4, Bean.BeanTypes.Arabica)).GrindBeans().AddWater(15, true);
                Console.WriteLine(beverage.ToBeverage());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
