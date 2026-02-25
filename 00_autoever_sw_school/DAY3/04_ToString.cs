using static System.Console;

class Point 
{
	private int x = 0;
	private int y = 0;

	public Point(int a, int b) => (x, y) = (a, b);
}

class Program 
{
	public static void Main()
	{
		Point p = new Point(1, 2);

		string s = p.ToString();

		WriteLine(s);
    }
}
