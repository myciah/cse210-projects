public abstract class Shape
{
    private string color;
    public Shape(string col)
    {
        color = col;
    }
    public string GetColor()
    {
        return color;
    }
    public void SetColor(string col)
    {
        color = col;
    }
    public abstract double GetArea();
}