using System.Windows;
using System.Windows.Controls;

// 프로그램을 배우는 것
// 1. 프로그래밍 언어
// 2. 해당 언어로 만들어진 라이브러리 사용법

// Framework: 라이브러리 사용 시 지켜야 하는 규칙
// => WPF: Window Presentation Framework
// 각 라이브러리는 자신만의 규칙이 있음

// WPF 규칙
// => 윈도우에 여러 개의 자식 컨트롤을 붙이려면 Panel을 사용해야 함

class MainWindow : Window {

    public MainWindow() {
        StackPanel sp = new StackPanel();
        Content = sp;

        //sp.Orientation = Orientation.Horizontal;
        sp.Orientation = Orientation.Vertical; // 디폴트 값

        // 자식 컨트롤 부착
        sp.Children.Add(new Button());
        sp.Children.Add(new Slider());
        sp.Children.Add(new ProgressBar { Value = 50, Height = 20 });
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