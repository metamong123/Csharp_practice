using System.Windows;
using System.Windows.Input;

// C# WPF 내부에 아래 코드가 있음
/*
class Window {
    // 다양한 필드와 메소드, Property
    
    // 윈도우 위에서 어떤 이벤트가 발생되면
    // 자동으로 호출되는 약속된 메소드
    virtual void OnMouseLeftButtonDown(...) { }
    virtual void OnMouseRightButtonDown(...) { }
}
*/

// WPF 일반적인 코딩 관례
// => Window라는 클래스를 직접 사용하는 것이 아니라
// => Window의 파생 클래스를 만들어서 사용
class MainWindow: Window {
    protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e) {
        MessageBox.Show("LBUTTONDOWN");
        // base: 기반 클래스
        // 기반 클래스의 함수도 실행되도록 자동 생성된 코드
        base.OnMouseLeftButtonDown(e);
    }
    protected override void OnMouseRightButtonDown(MouseButtonEventArgs e) {
        MessageBox.Show("RBUTTONDOWN");
        base.OnMouseRightButtonDown(e);
    }

    protected override void OnKeyDown(KeyEventArgs e) {
        MessageBox.Show("KEYDOWN");
        base.OnKeyDown(e);
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