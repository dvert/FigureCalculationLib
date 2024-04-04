using FigureCalculationLibrary.Interfaces;

namespace FigureCalculationLibrary.Figures
{
    public class Circle : IFigure
    {
        #region Properties

        /// <param name="Radius">Сircle radius</param>
        public double Radius { get; private set; }

        #endregion

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException("Radius value must be greater than 0", nameof(radius));

            Radius = radius;
        }

        #region Functions

        /// <summary>
        /// Calculating the area of ​​a Circle
        /// </summary>
        public double CalculateArea() => Math.PI * Math.Pow(Radius, 2);

        #endregion
    }
}
