using Figure_area_сalculation;
using static Figure_area_сalculation.Round;

namespace FigureAreaCalculationTests
{
    internal class RoundTests
    {
        [Test]
        public void Round_CreateRoundToString_Success()
        {
            string expected = "Figure is Round";

            Round actual = CreationFigure(4);

            Assert.That(actual.ToString(), Is.EqualTo(expected));
        }

        [Test]
        public void Round_CreateRoundImpossible_Fault()
        {
            Assert.Throws<ArgumentException>(() => CreationFigure(-1));
        }

        [Test]
        public void Round_CreateRoundCheckingSides_Success()
        {
            int expected = 3;

            Round actual = CreationFigure(3);

            Assert.That(actual.Radius, Is.EqualTo(expected));
        }

        [Test]
        public void Round_GetArea_Success()
        {
            double expected = 50.2;

            Round actual = CreationFigure(4);

            Assert.That(actual.GetArea(), Is.EqualTo(expected).Within(0.1));
        }
    }
}
