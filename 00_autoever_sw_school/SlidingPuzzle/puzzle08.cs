using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Media;

// puzzle Step 8. 게임판의 상태를 나타내는 2차원 배열 도입
// => 자료구조(배열)을 사용해서 게임의 상태를 관리

class MainWindow : Window {
    private int bw = 0;
    private int bh = 0;

    private const int COUNT = 5;
    private const int EMPTY = COUNT * COUNT - 1;

    private Grid grid;

    // ==================================================
    // 이번 단계의 핵심 - 게임판의 상태를 관리하는 2차원 배열
    private int[,] state = new int[COUNT, COUNT];

    public void InitState() {
        // 2차원 배열을 0 ~ 24로 채우는 코드
        // => 게임판의 블럭이 섞여있지 않은 상태
        for (int y = 0; y < COUNT; y++) {
            for (int x = 0; x < COUNT; x++) {
                state[y, x] = y * COUNT + x;
            }
        }
    }
    // ==================================================

    public void InitPanel() {
        grid = new Grid();

        for (int i = 0; i < COUNT; i++) {
            grid.RowDefinitions.Add(new RowDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());
        }
        Content = grid;
    }

    public void MakeGridImage() {
        Uri uri = new Uri("C:\\Users\\한국전파진흥협회\\Desktop\\실습\\10_C#_프로그래밍\\SlidingPuzzle\\totoro.jpg");

        BitmapImage bm = new BitmapImage(uri);

        bw = (int)(bm.PixelWidth / COUNT);
        bh = (int)(bm.PixelHeight / COUNT);

        for (int y = 0; y < COUNT; y++) {
            for (int x = 0; x < COUNT; x++) {

                // state 배열에 있는 정보를 가지고 블럭 선택
                if (state[y, x] != EMPTY) {
                    int bno = state[y, x];
                    // bno가 8이라면 8번 블럭의 x, y를 알아야 함
                    int bx = bno % COUNT; // 3
                    int by = bno / COUNT; // 1

                    Int32Rect rc = new Int32Rect(bx * bw, by * bh, bw, bh);
                    CroppedBitmap cb = new CroppedBitmap(bm, rc);
                    Image img = new Image {
                        Source = cb,
                        Stretch = Stretch.Fill,
                        Margin = new Thickness(0.5)
                    };

                    Grid.SetRow(img, y);
                    Grid.SetColumn(img, x);

                    grid.Children.Add(img);
                }
            }
        }
    }

    public MainWindow() {
        InitState();
        InitPanel();
        MakeGridImage();
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