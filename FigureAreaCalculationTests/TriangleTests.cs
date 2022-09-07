using Figure_area_ñalculation;
using static Figure_area_ñalculation.Triangle;

namespace FigureAreaCalculationTests
{

    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void TestTriangle_CreateTriangleToString_Success()
        {
            string expected = "Figure is Triangle";

            Triangle actual = CreationFigure(4, 3, 5);

            Assert.That(actual.ToString(), Is.EqualTo(expected));
        }

        [Test]
        public void TestExistenceCheck_CreateTriangleImpossible_Fault()
        {
            Assert.Throws<ArgumentException>(() => CreationFigure(3, 1, 5));
        }

        [Test]
        public void TestTriangle_CreateTriangleCheckingSides_Success()
        {
            int[] expected = new[] { 4, 5, 6 };

            Triangle actual = CreationFigure(4, 5, 6);

            Assert.Multiple(() =>
            {
                Assert.That(actual.A, Is.EqualTo(expected[0]));
                Assert.That(actual.B, Is.EqualTo(expected[1]));
                Assert.That(actual.C, Is.EqualTo(expected[2]));
            });
        }

        [TestCase(0, int.MinValue, int.MaxValue)]
        [TestCase(int.MinValue, 0, int.MaxValue)]
        [TestCase(int.MaxValue, int.MaxValue, 0)]
        public void TestTriangle_BoundaryValues_Fault(int firstValue, int secondValue, int thirdValue)
        {
            Assert.Throws<ArgumentException>(() => CreationFigure(firstValue, secondValue, thirdValue));
        }

        [Test]
        public void TestTriangle_GetArea_Success()
        {
            double expected = 9.92;

            Triangle actual = CreationFigure(4, 5, 6);

            Assert.That(actual.GetArea(), Is.EqualTo(expected).Within(0.01));
        }

        [Test]
        public void TestTriangle_GetPerimeter_Success()
        {
            double expected = 15;

            Triangle actual = CreationFigure(4, 5, 6);

            Assert.That(actual.GetPerimeter(), Is.EqualTo(expected));
        }
    }
}