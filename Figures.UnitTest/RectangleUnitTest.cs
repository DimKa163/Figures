using Figures.Abstractions;
using Figures.Factory;

namespace Figures.UnitTest
{
    public class RectangleUnitTest
    {
        private readonly FigureFactory _figureFactory;
        public RectangleUnitTest()
        {
            _figureFactory = new FigureFactory();
        }

        [Fact]
        public void RectangleSquareIs6()
        {
            double a = 1;
            double b = 2;
            IFigure figure = _figureFactory.CreateRectangle(a, b);
            var square = 6;

            var result = figure.GetSquare();

            Assert.Equal(square, result);
        }
        [Fact]
        public void RectangleSquareIs31_4()
        {
            double a = 5.2;
            double b = 10.5;
            IFigure figure = _figureFactory.CreateRectangle(a, b);
            var square = 31.4;

            var result = figure.GetSquare();

            Assert.Equal(square, result);
        }
    }
}
