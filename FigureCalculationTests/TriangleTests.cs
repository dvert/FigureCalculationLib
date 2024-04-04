using FigureCalculationLibrary.Figures;


namespace FigureCalculationTests
{
    public class TriangleTests
    {
        [Test]
        public void InitTriangleException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, -1, -1));
            Assert.Throws<ArgumentException>(() => new Triangle(10, 2, 3));
        }

        [Test]
        public void TriangleAreaCalculation()
        {
            var triangle = new Triangle(3, 4, 5);

            double expectedArea = 6;

            Assert.That(triangle.CalculateArea(), Is.EqualTo(expectedArea).Within(0.0001));
        }

        [Test]
        public void RightAngledTriangleCheck()
        {
            var rightTriangle = new Triangle(3, 4, 5);
            var nonRightTriangle = new Triangle(2, 4, 5);

            Assert.That(rightTriangle.IsRightTriangle(), Is.True);
            Assert.That(nonRightTriangle.IsRightTriangle(), Is.False);
        }

        [Test]
        public void NotValidTriangleSidesException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 6));
        }

        [Test]
        public void IsSomeSideIsZeroException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, 0, 6));
        }
    }
}
