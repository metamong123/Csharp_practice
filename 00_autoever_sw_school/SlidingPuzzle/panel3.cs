using System.Windows;
using System.Windows.Controls;

class MainWindow : Window {

    public MainWindow() {
        DockPanel dp = new DockPanel();
        Content = dp;

        // DockPanel은 top, bottom, left, right로 부착
        Button b1 = new Button { Content = "버튼1" };
        Button b2 = new Button { Content = "버튼2" };
        Button b3 = new Button { Content = "버튼3" };
        Button b4 = new Button { Content = "버튼4" };

        // DockPanel 설정 변경
        dp.LastChildFill = false;

        // 각 버튼이 DockPanel의 어디에 놓일지 설정
        DockPanel.SetDock(b1, Dock.Top);
        DockPanel.SetDock(b2, Dock.Left);
        DockPanel.SetDock(b3, Dock.Right);
        DockPanel.SetDock(b4, Dock.Bottom);

        // 각 버튼을 DockPanel에 부착
        dp.Children.Add(b1);
        dp.Children.Add(b2);
        dp.Children.Add(b3);
        dp.Children.Add(b4); // 마지막 자식이 나머지 모든 여유공간 사용
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