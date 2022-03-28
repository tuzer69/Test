namespace Test.Base;

public abstract class Figure : IFigure
{
    private protected const double _pi = 3.1415926535;

    public abstract string Type { get; }

    public abstract double GetSquare();

}