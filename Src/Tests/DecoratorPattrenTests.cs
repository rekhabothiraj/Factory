using FactoryPattern;
using FactoryPattern.DecoratorPattern;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class DecoratorPattrenTests
    {
        [Test]
        public void ShouldOrderWeddingCakes()
        {
            var bakery = new Wedding();

            var cakeDesign = bakery.SelectCakesDesign();

            var price = bakery.CalculatethePrice();

            Assert.That(cakeDesign, Is.EqualTo("Step"));
            Assert.That(price, Is.EqualTo(50.3m));
        }



        [Test]
        public void ShouldOrderBirthDayCakes()
        {
            Bakery birthDayCakes = new BirthDayCakes();

            var cakeDesign = birthDayCakes.SelectCakesDesign();
            var price = birthDayCakes.CalculatethePrice();

            Assert.That(cakeDesign, Is.EqualTo("MickeyMouse"));
            Assert.That(price, Is.EqualTo(100m));
        }




        [Test]
        public void ShouldBeAbleToAddToppingsToBirthDayCakes()
        {
            var birthDayCakes = new BirthDayCakes();

            Bakery chocklate = new Chocklate(birthDayCakes);
            var design = chocklate.SelectCakesDesign();
            var price = chocklate.CalculatethePrice();

            Assert.That(design, Is.EqualTo("MickeyMouse with chocklateToppings"));
            Assert.That(price, Is.EqualTo(120m));
        }


        [Test]
        public void ShouldBeAbleToAddToppingsToWeddingCakes()
        {
            Bakery wedding = new Wedding();

            Bakery chocklate = new Chocklate(wedding);
            var design = chocklate.SelectCakesDesign();
            var price = chocklate.CalculatethePrice();

            Assert.That(design, Is.EqualTo("Step with chocklateToppings"));
            Assert.That(price, Is.EqualTo(70.3m));
        }


        [Test]
        public void ShouldAllowToaddMultipleToppingToTheCakes()
        {
            var birthDayCakes = new BirthDayCakes();
            var chocklate = new Chocklate(birthDayCakes);
            Bakery fruit = new Fruit(chocklate);

            var design = fruit.SelectCakesDesign();
            var price = fruit.CalculatethePrice();
            Assert.That(design, Is.EqualTo("MickeyMouse with chocklateToppings ,with fruit"));
            Assert.That(price, Is.EqualTo(130m));
        }
    }

    public class Fruit : Bakery
    {
        private readonly Chocklate _chocklate;

        public Fruit(Chocklate chocklate)
        {
            _chocklate = chocklate;
        }

        public override string SelectCakesDesign()
        {
            return string.Format("{0} ,with fruit", _chocklate.SelectCakesDesign());
        }

        public override decimal CalculatethePrice()
        {
            return _chocklate.CalculatethePrice() + 10m;
        }
    }

    public class Chocklate: Bakery
    {
        private readonly Bakery _bakery;

        public Chocklate(Bakery bakery)
        {
            _bakery = bakery;
        }

        public override string SelectCakesDesign()
        {
            return string.Format("{0} with chocklateToppings", _bakery.SelectCakesDesign());
        }

        public override decimal CalculatethePrice()
        {
            return _bakery.CalculatethePrice() + 20m;
        }
    }
}