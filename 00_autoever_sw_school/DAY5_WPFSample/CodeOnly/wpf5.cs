using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

// step5. UI를 XML로 구축
// 1. ui1.txt 파일 추가(확장자는 상관 X)

class MainWindow : Window {
    public MainWindow() {
        this.Title = "Hello, WPF";

        // =============================================================
        // 실행파일 위치 기준으로 "ui.txt 위치: "../../../ui1.txt"

        // #1. 파일 오픈
        FileStream fs = new FileStream("../../../ui1.txt",
                                        FileMode.Open, FileAccess.Read);

        // #2. 파일의 내용(XML)에 따라 컨트롤 생성
        Button btn = (Button)XamlReader.Load(fs);

        fs.Close();
        // =============================================================
        this.Content = btn;
    }
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