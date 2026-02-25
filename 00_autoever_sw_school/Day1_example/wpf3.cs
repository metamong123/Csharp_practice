using System.Windows;

class Program {
    [STAThread]
    public static void Main() {
        Window w = new Window();
        w.Show();

        // 윈도우에서 발생하는 이벤트에 대한 기본 처리
        Application app = new Application();
        app.Run();
    }
}