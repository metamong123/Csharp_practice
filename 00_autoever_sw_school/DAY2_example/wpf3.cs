using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

class Program {
    [STAThread]
    public static void Main() {
        Window w = new Window();

        w.Title = "Hello"; // 윈도우의 캡션 문자열에 나타낼 문자열 설정

        // Content 속성 : 캡션바가 아닌 Window 자체에 나타낼 "컨텐츠" 연결
        //w.Content = "Hello";

        //w.Content = new Button { Content = "OK" };

        //w.Content = new Slider();

        // 그림 나타내기
        BitmapImage bm = new BitmapImage();
        bm.BeginInit();
        bm.UriSource = new Uri(System.IO.Path.GetFullPath(@"..\\..\\..\\aaa.png"));
        bm.EndInit();

        Image img = new Image();
        img.Source = bm;
        w.Content = img; // window의 컨텐츠로 그림 연결

        w.Show();

        Application app = new Application();
        app.Run();
    }
}