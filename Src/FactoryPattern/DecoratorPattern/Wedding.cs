namespace FactoryPattern.DecoratorPattern
{
    public class Wedding :Bakery
    {
        public override string SelectCakesDesign()
        {
            return "Step";
        }

        public override decimal CalculatethePrice()
        {
            return 50.3m;
        }
    }
}