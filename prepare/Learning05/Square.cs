public class Square : Shape
{
    private double side;
    public Square(string color, double sid) : base(color)
    {
        side = sid;
    }
    public override double GetArea()
    {
        return side * side;
    }
}