public class Rectangle : Shape
{
    private double length;
    private double width;
    public Rectangle(string color, double len, double wid) : base(color)
    {
        length = len;
        width = wid;
    }
    public override double GetArea()
    {
        return length * width;
    }
}