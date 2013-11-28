using System;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Class1
    {
        [TestCase("car", "car")]
        [TestCase("Bike", "bike")]
        [TestCase("carkjfkldjfksdjfk", "undefined")]
        public void ShouldCreateaBusinessClassForTheSelectedProduct(string product, string expected)
        {
            //call the factory class
            var factoryclass = new Factoryclass();
            Vehicle businessObject = factoryclass.GetTheSelecteditem(product.ToLower());
            Assert.IsInstanceOf(typeof (Vehicle), businessObject);
            Assert.That(businessObject.Buy(), Is.EqualTo(expected));
        }
    }

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
