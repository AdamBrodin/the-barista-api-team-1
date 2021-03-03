using BaristaApi;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[assembly: Parallelize(Workers = 4, Scope = ExecutionScope.ClassLevel)]

namespace BaristaTests
{
    [TestClass]
    public class UnitTest1
    {
        public FluentEspresso beverage;
        [TestMethod]

        public void CappuccinoTest()
        {
            beverage = new FluentEspresso().AddWater(50, 80).AddBeans(new Bean(5, Bean.BeanTypes.Arabica)).GrindBeans().AddMilk(25).AddFoamMilk(10);
            Assert.AreEqual("Cappuccino", beverage.ToBeverage());
        }

        [TestMethod]
        public void MoccaTest()
        {
            beverage = new FluentEspresso().AddWater(30, 85).AddBeans(new Bean(3, Bean.BeanTypes.Excelsa)).GrindBeans().AddChocolateSyrup(10).AddMilk(30);
            Assert.AreEqual("Mocha", beverage.ToBeverage());
        }

        [TestMethod]
        public void LatteTest()
        {
            beverage = new FluentEspresso().AddWater(40, 80).AddBeans(new Bean(3, Bean.BeanTypes.Robusta)).GrindBeans().AddMilk(40);
            Assert.AreEqual("Latte", beverage.ToBeverage());
        }

        [TestMethod]
        public void AmericanoTest()
        {
            beverage = new FluentEspresso().AddWater(25, 85).AddBeans(new Bean(4, Bean.BeanTypes.Arabica)).GrindBeans().AddWater(15);
            Assert.AreEqual("Americano", beverage.ToBeverage());
        }

        [TestMethod]
        public void EspressoTest()
        {
            beverage = new FluentEspresso().AddWater(25, 85).AddBeans(new Bean(5, Bean.BeanTypes.Arabica)).GrindBeans();
            Assert.AreEqual("Espresso", beverage.ToBeverage());
        }

        [TestMethod]
        public void MacchiatoTest()
        {
            beverage = new FluentEspresso().AddWater(25, 85).AddBeans(new Bean(5, Bean.BeanTypes.Arabica)).GrindBeans().AddFoamMilk(40);
            Assert.AreEqual("Macchiato", beverage.ToBeverage());
        }
    }
}
