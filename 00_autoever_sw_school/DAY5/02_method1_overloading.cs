using static System.Console;

class Math
{
    public int Square(int x)
    {
        return x * x;
    }
}

class Program
{
    public static void Main()
    {
        Math m = new Math();

        var ret1 = m.Square(3);
        var ret2 = m.Square(3.3);
    }
}