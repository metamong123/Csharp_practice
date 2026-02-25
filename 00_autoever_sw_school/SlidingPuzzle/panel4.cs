using System.Windows;
using System.Windows.Controls;

class MainWindow : Window {

    public MainWindow() {
        DockPanel dp = new DockPanel();
        Content = dp;

        TextBox tb = new TextBox();

        StackPanel sp = new StackPanel();

        DockPanel.SetDock(tb, Dock.Top);
        DockPanel.SetDock(sp, Dock.Bottom);

        dp.Children.Add(sp);
        dp.Children.Add(tb);

        sp.Orientation = Orientation.Horizontal;
        sp.HorizontalAlignment = HorizontalAlignment.Right;

        sp.Children.Add(new Button { Content = "OK", Width = 100, Height = 50 });
        sp.Children.Add(new Button { Content = "Cancel", Width = 100, Height = 50 });
    }
}

class program {
    [STAThread]
    public static void Main() {
        MainWindow w = new MainWindow();
        w.Show();

        Application app = new Application();
        app.Run();
    }
}