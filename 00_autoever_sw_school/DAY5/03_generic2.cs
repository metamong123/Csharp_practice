class Point
{
    private int x = 0;
    private int y = 0;

    public Point(int a, int b)
    {
        (x, y) = (a, b);
    }
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(1, 2);
    }
}