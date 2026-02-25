using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows.Input;

// puzzle Step #9. 블럭 이동하기

class MainWindow : Window {
    private int bw = 0;
    private int bh = 0;

    private const int COUNT = 5;
    private const int EMPTY = COUNT * COUNT - 1;

    private Grid grid;

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
                    int bx = bno % COUNT;
                    int by = bno / COUNT;

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

    protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e) {
        base.OnMouseLeftButtonDown(e);

        // 클릭 된 곳의 좌표를 grid 기반으로 얻기
        //Point pt = e.GetPosition(this); // this: 자기 자신을 의미
                                        // 즉, 윈도우를 기준으로 좌표를 얻음
        Point pt = e.GetPosition(grid); // grid를 기준으로 좌표 얻기

        // 좌표를 가지고 몇 번째 블럭을 클릭했는지 알아야 함
        // => 좌표 / 한 블럭의 크기
        // => 여기서 한 블럭은 그림의 크기가 아닌 grid의 한 블럭 크기
        int bx = (int)(pt.X / (grid.ActualWidth / COUNT));
        int by = (int)(pt.Y / (grid.ActualHeight / COUNT));

        Console.WriteLine("{0}, {1} 블럭 클릭", bx, by);

        // 게임판 밖이면 무시
        if (bx < 0 || bx >= COUNT || by < 0 || by >= COUNT) {
            return;
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