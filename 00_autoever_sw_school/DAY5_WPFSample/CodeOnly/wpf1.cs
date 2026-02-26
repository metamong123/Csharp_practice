using System.Windows;

// stpe1. 콘솔 프로젝트에서 WPF를 사용하기 위한 설정

class Program {
    [STAThread]
    public static void Main() {
        Window w = new Window();
        w.Show();

        Application app = new Application();
        app.Run();
    }
}