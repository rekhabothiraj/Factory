namespace FactoryPattern
{
    public abstract class Vehicle
    {
        public abstract string Buy();
    }

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

    public class Bike :Vehicle
    {
        public override string Buy()
        {
            return "bike".ToLower();
        }
    }

    public class Undefined : Vehicle
    {
        public override string Buy()
        {
            return "Undefined".ToLower();
        }
    }

    public class Car : Vehicle

    {
        public override string Buy()
        {
            return "car";
        }
    }
}
