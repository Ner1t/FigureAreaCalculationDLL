using Figure_area_calculation.Interfaces;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("FigureAreaCalculationTests")]

namespace Figure_area_сalculation
{
    internal class Triangle : IFigured
    {
        public double A { get; init; }
        public double B { get; init; }
        public double C { get; init; }

        public bool RightTriangle() => ((A * A + B * B == C * C)
            || (A * A + C * C == B * B)
            || (C * C + B * B == A * A));

        private Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public static Triangle CreationFigure(double a, double b, double c)
        {
            if ((a + b < c
                   || b + c < a
                   || c + a < b)
                   || ((a == 0 | b == 0 | c == 0)))
            {
                throw new ArgumentException("Such a triangle cannot exist!");
            }
            else
            {
                return new Triangle(a, b, c);
            }
        }

        public double GetArea()
        {
            double p = GetPerimeter() / 2;
            double temp = p * (p - A) * (p - B) * (p - C);
            return Math.Sqrt(temp);
        }

        public double GetPerimeter()
        {
            return A + B + C;
        }


        public override string ToString()
        {
            return $"Figure is {nameof(Triangle)}";
        }
    }
}
