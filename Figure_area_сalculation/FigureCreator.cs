using Figure_area_calculation.Interfaces;

namespace Figure_area_сalculation
{
    internal class FigureCreator
    {
        private readonly IFigured _figure;

        public double GetArea => _figure.GetArea();

        public FigureCreator(double sideA, double sideB, double sideC)
        {
            _figure = Triangle.CreationFigure(sideA, sideB, sideC);
        }

        public FigureCreator(double radius)
        {
            _figure = Round.CreationFigure(radius);
        }

        public void FigureTypeMessage() => Console.WriteLine(_figure.ToString());
    }
}
