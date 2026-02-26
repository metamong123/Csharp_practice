using System.Windows;

// step3. Main 함수를 App 안으로
// => 2개의 클래스로 구성된 프로그램

class MainWindow : Window {
    
}

class App: Application {
    [STAThread]
    public static void Main() {
        MainWindow w = new MainWindow();
        w.Show();

        App app = new App();
        app.Run();
    }
}