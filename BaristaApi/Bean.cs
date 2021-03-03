namespace BaristaApi
{
    public class Bean
    {
        public double weightGrams;
        public BeanTypes beanType;
        public enum BeanTypes
        {
            Arabica,
            Robusta,
            Liberica,
            Excelsa
        }

        public Bean(double weightGrams, BeanTypes beanType)
        {
            this.weightGrams = weightGrams;
            this.beanType = beanType;
        }
    }
}
