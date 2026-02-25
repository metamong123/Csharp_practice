using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

class MainWindow : Window {

    public MainWindow() {
        Uri uri = new Uri("C:\\totoro.jpg");
        BitmapImage bm = new BitmapImage(uri);

        // Load된 비트맵에서 일부분을 Crop
        Int32Rect rc = new Int32Rect(500, 500, 100, 100);
        CroppedBitmap cb = new CroppedBitmap(bm, rc);
        Image img = new Image { Source = cb }; // 일부와 연결

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