using Figure_area_calculation.Interfaces;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("FigureAreaCalculationTests")]

namespace Figure_area_сalculation
{
    internal class Round : IFigured
    {
        public double Radius { get; init; }

        private Round(double radius)
        {
            Radius = radius;
        }

        public static Round CreationFigure(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException($"{nameof(radius)} cannot be negative!");
            }
            else
            {
                return new Round(radius);
            }
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            return $"Figure is {nameof(Round)}";
        }
    }
}
