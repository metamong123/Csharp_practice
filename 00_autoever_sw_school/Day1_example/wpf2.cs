// 직접 Window 만들기

using System.Windows;

class Program {
    // GUI를 만든 경우, Main 위에 반드시 아래 한줄 필요(관례적인 코드)
    [STAThread]
    public static void Main() {
        Window w = new Window();
        w.Show();

        MessageBox.Show("Hello");

        // 프로그램이 즉시 종료 되므로 윈도우가 바로 사라짐
    }
}