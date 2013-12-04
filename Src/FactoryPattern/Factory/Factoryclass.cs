namespace FactoryPattern.Factory
{
    public class Factoryclass
    {
        public Vehicle GetTheSelecteditem(string product)
        {
            if (product == "car")
            {
                Vehicle car = new Car();
                return car;
            }
            if (product == "bike")
            {
                var bike = new Bike();
                return bike;
            }
            return new Undefined();
        }
    }
}