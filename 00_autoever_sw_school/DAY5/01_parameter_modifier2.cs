using static System.Console;

class MyMath
{
    public static int AddSub(int a, int b, ref int ret)
    {
        ret = a - b;
        return a + b;
    }
}

class Program
{

    public static void Main()
    {
        int ret1 = 0;  

        int ret2 = AddSub(5, 3, ref ret1); 

        WriteLine($"{ret1}, {ret2}"); 
    }
}