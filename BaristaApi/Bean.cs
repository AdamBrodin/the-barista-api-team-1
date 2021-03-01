namespace BaristaApi
{
    public class Bean
    {
        public int weightGrams;
        public BeanTypes beanType;
        public enum BeanTypes
        {
            Arabica,
            Robusta,
            Liberica,
            Excelsa
        }
    }
}
