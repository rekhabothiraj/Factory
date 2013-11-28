using System;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void ShouldCreateaBusinessClassForTheSelectedProduct()
        {
            string product = "bike";

            //call the factory class
            var factoryclass = new Factoryclass();
            Vehicle businessObject = factoryclass.GetTheSelecteditem(product);
            Assert.IsInstanceOf(typeof (Vehicle), businessObject);
            Assert.That(businessObject.Buy(), Is.EqualTo("undefined"));
        }


        [Test]
        public void ShouldBe()
        {

            string product = "Car";

            var factoryclass = new Factoryclass();
            Vehicle businessObject = factoryclass.GetTheSelecteditem(product);
            var car = businessObject.Buy();
            Assert.That(car ,Is.EqualTo("car"));
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
            if (product.ToLower() == "car")
            {
                Vehicle car = new Car();
                return car;
            }
            return new Undefined();
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
