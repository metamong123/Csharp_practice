using System.Windows;

class MainWindow: Window {

}

class program {
    [STAThread]
    public static void Main() {
        MainWindow w = new MainWindow();
        w. Show();

        Application app = new Application();
        app.Run();
    }
}