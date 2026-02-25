using System.Windows;

/*
class Window {
    // Title, Width, Content 등의 다양한 Property 제공
}
*/

class MainWindow: Window {
    // 생성자: 객체가 생성될 때 자동으로 호출되는 함수
    //        여기서 윈도우 GUI 관련 초기화 코드를 작성
    public MainWindow() {
        // 아래의 모든 속성은 "기반 클래스"인 Window로부터 상속받은 것
        Title = "Hello";
        Width = 500;
        Height = 500;
        Content = "ABCD";

        Topmost = true; // 다른 윈도우를 선택해도 항상 위에 있도록 함
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