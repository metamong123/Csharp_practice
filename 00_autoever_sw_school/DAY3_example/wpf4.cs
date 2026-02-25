using System.Windows;
using System.Windows.Controls;

class MainWindow: Window {
    public MainWindow() {
        Title = "Hello";
        
        // 가장 중요한 Property: Content
        // => 윈도우 위에 나타낼 한 개의 컨텐츠를 연결 가능
        //Content = "ABCD";         // 문자열도 되고
        //Content = new Button(); // 다양한 컨트롤 및 그림도 가능

        //그러나 Content에는 한 개만 연결 가능
        // 여러 개의 자식 컨트롤을 만들려면
        // => 여러 개의 컨트롤을 관리하는 Panel 도구 연결
        StackPanel sp = new StackPanel();

        Content = sp; // 윈도우 위에 StackPanel을 붙인 것
                      // Panel 자체는 투명해서 보이지 않음

        // 다양한 컨트롤을 Panel에 붙일 수 있음
        Button b1 = new Button { Content = "버튼1", FontSize = 32 };
        sp.Children.Add(b1);

        Slider slider = new Slider();
        sp.Children.Add(slider);

        RadioButton radio = new RadioButton();
        sp.Children.Add(radio);

        sp.Children.Add(new Button { Content = "버튼2" });
    }
}

class Program {
    [STAThread]
    public static void Main() {
        MainWindow w = new MainWindow();
        w.Show();

        Application app = new Application();
        app.Run();
    }
}