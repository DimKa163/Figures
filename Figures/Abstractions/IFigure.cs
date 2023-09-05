namespace Figures.Abstractions
{
    public interface IFigure
    {
        FigureType Type { get; }

        double GetSquare();
    }
}
