namespace FactoryPattern.Factory
{
    public class Bike :Vehicle
    {
        public override string Buy()
        {
            return "bike".ToLower();
        }
    }
}