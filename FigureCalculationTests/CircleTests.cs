using FigureCalculationLibrary.Figures;

namespace FigureCalculationTests
{
    public class CircleTests
    {
        [Test]
        public void InitCircleException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-1));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(0));
        }

        [Test]
        public void CircleAreaCalculation()
        {
            var circle = new Circle(5);
            double expectedArea = Math.PI * Math.Pow(5, 2);
            Assert.That(circle.CalculateArea(), Is.EqualTo(expectedArea).Within(0.0001));
        }

    }   
}
