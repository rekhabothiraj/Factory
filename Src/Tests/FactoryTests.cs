using System;
using FactoryPattern.Factory;
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
}
