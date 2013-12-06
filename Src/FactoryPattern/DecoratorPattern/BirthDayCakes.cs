namespace FactoryPattern.DecoratorPattern
{
    public class BirthDayCakes : Bakery
    {
        public override string SelectCakesDesign()
        {
            return "MickeyMouse";
        }

        public override decimal CalculatethePrice()
        {
            return 100m;
        }
    }
}