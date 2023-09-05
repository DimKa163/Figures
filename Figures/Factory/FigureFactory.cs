namespace Figures.Factory
{
    public class FigureFactory
    {
        public Circle CreateCircle(double radius)
        {
            return new Circle(radius);
        }

        public Triangle CreateTriangle(double a, double b, double c)
        {
            return new Triangle(a, b, c);
        }

        public Rectangle CreateRectangle(double a, double b)
        {
            return new Rectangle(a, b);
        }
    }
}
