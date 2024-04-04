using FigureCalculationLibrary.Interfaces;

namespace FigureCalculationLibrary.Figures
{
    public class Triangle : IFigure
    {
        #region Properties

        /// <param name="SideA">First side</param>
        /// <param name="SideB">Second side</param>
        /// <param name="SideC">Third side</param>
        /// <param name="Sides">Array of sides</param>
        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }
        public double [] Sides { get; private set; }

        #endregion

        public Triangle(double sideA, double sideB, double sideC)
        {
            ValidateSides(sideA, sideB, sideC);

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;

            Sides = [SideA, SideB, SideC];
        }

        #region Validation
        /// <summary>
        /// Input data checking
        /// </summary>
        private void ValidateSides(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentOutOfRangeException("The length of all sides must be greater than 0");

            if ((sideA >= sideB + sideC) || (sideB >= sideA + sideC) || (sideC >= sideA + sideB))
                throw new ArgumentException("A triangle with such sides does not exist");
        }
        #endregion

        #region Functions


        /// <summary>
        /// Сhecking if the triangle is right-angled
        /// </summary>
        public bool IsRightTriangle()
        {
            var sides = Sides.Select(x => x).OrderByDescending(x => x).ToArray();

            if (Math.Pow(sides[0], 2) == (Math.Pow(sides[1], 2) + Math.Pow(sides[2], 2)))
                return true;

            return false;
        }

        /// <summary>
        /// Calculating the area of ​​a triangle
        /// </summary>
        public double CalculateArea()
        {
            double half_perimeter = Sides.Select(x=>x).Sum() / 2;

            return Math.Sqrt(half_perimeter * (half_perimeter - SideA) * (half_perimeter - SideB) * (half_perimeter - SideC));
        }
        #endregion
    }
}
