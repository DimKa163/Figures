using Figures.Abstractions;

namespace Figures
{
    public class Rectangle : IFigure
    {
        private readonly double _a, _b;
        public Rectangle(double a, double b)
        {
            _a = a;
            _b = b;
        }
        public FigureType Type => FigureType.Rectangle;

        public double GetSquare()
        {
            return Math.Round((_a + _b) * 2, 2);
        }
    }
}
