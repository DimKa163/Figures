using Figures.Abstractions;

namespace Figures
{
    public class Triangle : IFigure
    {
        private readonly double _a, _b, _c;
        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }
        public FigureType Type => FigureType.Triangle;

        public double GetSquare()
        {
            double p = (_a + _b + _c) / 2;
            return Math.Round(Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c)), 2);
        }
    }
}
