namespace FactoryPattern.Factory
{
    public class Undefined : Vehicle
    {
        public override string Buy()
        {
            return "Undefined".ToLower();
        }
    }
}