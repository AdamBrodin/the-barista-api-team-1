using System;

namespace BaristaApi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FluentEspresso cappuccino = new FluentEspresso().AddWater(50, 85).AddBeans(new Bean(5, Bean.BeanTypes.Arabica)).GrindBeans().AddMilk(25).AddFoamMilk(10);


                FluentEspresso mocca = new FluentEspresso().AddWater(30, 90).AddBeans(new Bean(3, Bean.BeanTypes.Excelsa)).GrindBeans().AddChocolateSyrup(10).AddMilk(30);
                Console.WriteLine("You have made a: " + cappuccino.ToBeverage());
                Console.WriteLine("You have made a: " + mocca.ToBeverage());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
