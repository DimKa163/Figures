using Figures.Abstractions;
using Figures.Factory;

namespace Figures.UnitTest
{
    public class CircleUnitTest
    {
        private readonly FigureFactory _figureFactory;
        public CircleUnitTest()
        {
            _figureFactory = new FigureFactory();
        }

        [Fact]
        public void CircleSquareIs314()
        {
            double radius = 1;
            IFigure figure = _figureFactory.CreateCircle(radius);
            var square = 3.14;

            var result = figure.GetSquare();

            Assert.Equal(square, result);
        }
        [Fact]
        public void CircleSquareIs1962()
        {
            double radius = 2.5;
            IFigure figure = _figureFactory.CreateCircle(radius);
            var square = 19.62;

            var result = figure.GetSquare();

            Assert.Equal(square, result);
        }
    }
}