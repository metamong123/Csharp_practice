using System.Windows;

class Program {
    [STAThread]
    public static void Main() {
        Window w = new Window { Title = "Hello", Width = 300, Height = 300 };

        w.Show();

        Application app = new Application();
        app.Run();
    }
}