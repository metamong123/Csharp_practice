
class Point
{
    public int X { get; set; } = 0;
    public int Y { get; set; } = 0;
    public Point(int a, int b) => (X, Y) = (a, b);
    public override string ToString() => $"({X}, {Y})"; 
}

class Program
{
    static void Main()
    {
        Point p = new Point(1, 2);

        Console.WriteLine(p.ToString());    
    }
}
