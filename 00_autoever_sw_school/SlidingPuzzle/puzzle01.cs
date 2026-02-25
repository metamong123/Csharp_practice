using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

class MainWindow : Window {

    public MainWindow() {
        // 1. 자원의 경로를 관리하는 객체 생성
        Uri uri = new Uri("C:\\totoro.jpg"); // 그림 경로

        // 2. 그림(Bitmap)을 Load하는 객체 생성
        BitmapImage bm = new BitmapImage(uri);

        // 3. Load 된 그림을 Content로 연결 또는 panel의 자식으로 넣으려면
        // => Image 타입의 객체 필요
        Image img = new Image { Source = bm };

        // 4. Content에 연결
        Content = img;
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