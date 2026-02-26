using System.Windows;

// stpe2. Window와 Application 클래스
// WPF에는 수천 개의 클래스가 있지만, 핵심 클래스는 2개

// Window     : 프로그램의 주 윈도우를 만들 때 사용
// Application: 프로그램의 시작, 끝, event 처리를 담당

// 관례는 WPF 클래스에서 상속 받아서 사용
class MainWindow : Window {
    // 주된 UI 담당
}

// App: UI는 아니고 ,프로그램의 life cycle 주기에서 사용자가 하고 싶은 구현 작성
class App: Application {
    protected override void OnExit(ExitEventArgs e) {
        Console.WriteLine("프로그램 종료");
        base.OnExit(e);
    }

    protected override void OnStartup(StartupEventArgs e) {
        Console.WriteLine("프로그램 시작");
        base.OnStartup(e);
    }
}

class Program {
    [STAThread]
    public static void Main() {
        MainWindow w = new MainWindow();
        w.Show();

        App app = new App();
        app.Run();
    }
}