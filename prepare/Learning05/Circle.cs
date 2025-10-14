public class Circle : Shape
{
    private double radius;
    public Circle(string color, double rad) : base (color)
    {
        radius = rad;
    }
    public override double GetArea()
    {
        return radius * radius * Math.PI;
    }
}