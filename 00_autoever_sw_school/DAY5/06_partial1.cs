class Window
{
    public void Show() 
    {
        Console.WriteLine("Window is shown");
    }   
}

class Program
{
    static void Main()
    {
        Window w = new Window();
        w.Show();
    }
}