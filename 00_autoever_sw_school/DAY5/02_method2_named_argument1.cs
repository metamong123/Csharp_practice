
class Rect
{
    public void Set(int x, int y, int width, int height) { }
}

class Program
{
    public static void Main()
    {
        Rect rc = new Rect();

        rc.Set(1, 1, 10, 10);
    }
}
