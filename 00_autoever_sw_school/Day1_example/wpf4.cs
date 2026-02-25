using System.Drawing;
using System.Windows;
using System.Windows.Media;

class Program {
    [STAThread]
    public static void Main() {
        Window w = new Window();
        w.Show();
        w.Title = "AAA";
        w.Width = 300;
        w.Height = 200;

        w.Background = new SolidColorBrush(Colors.Yellow);

        // 윈도우 캡션 문자열을 "AAA"로 변경
        Application app = new Application();
        app.Run();
    }
}