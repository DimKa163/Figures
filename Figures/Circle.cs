using Figures.Abstractions;

namespace Figures
{
    public class Circle : IFigure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }
        public FigureType Type => FigureType.Circle;

        public double GetSquare()
        {
            return Math.Round(Math.Pow(_radius, 2) * Math.Round(Math.PI, 2), 2);
        }
    }
}