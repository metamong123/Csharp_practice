using static System.Console;

class Example
{
    public void M1(int a, int b, int c)
    {
    }
}

class Program
{
    public static void Main()
    {
        Example e = new Example();

        e.M1(1, 2, 3);
        e.M1(1, 2);
    }
}