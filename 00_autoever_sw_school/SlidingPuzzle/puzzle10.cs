using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows.Input;
using System.Media;

// puzzle Step 10. 블럭 이동
// => 마무리 단계

class MainWindow : Window {
    private int bw = 0;
    private int bh = 0;

    private const int COUNT = 5;
    private const int EMPTY = COUNT * COUNT - 1;

    private Grid grid;

    private int[,] state = new int[COUNT, COUNT];

    public void InitState() {
        Random rand = new Random();
        for (int y = 0; y < COUNT; y++) {
            for (int x = 0; x < COUNT; x++) {
                state[y, x] = y * COUNT + x;
            }
        }

        //for (int i = state.Length - 1; i > 0; i--) {
        //    int j = rand.Next(0, i + 1);
        //    int hold = state[i];
        //    state[i] = state[j];
        //    state[j] = hold;
        //}

        //// 3. 셔플된 데이터를 2차원 배열에 대입
        //for (int i = 0; i < 25; i++) {
        //    // i / 5는 행(Row), i % 5는 열(Column)이 됩니다.
        //    grid[i / 5, i % 5] = state[i];
        //}
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

        Point pt = e.GetPosition(grid);
        int bx = (int)(pt.X / (grid.ActualWidth / COUNT));
        int by = (int)(pt.Y / (grid.ActualHeight / COUNT));
        //Console.WriteLine("{0}, {1} 블럭 클릭", bx, by);

        if (bx < 0 || bx >= COUNT || by < 0 || by >= COUNT) return;

        // bx, by: 사용자가 클릭한 위치가 Grid의 몇 번째 블럭인가에 대한 정보
        if (bx > 0 && state[by, bx - 1] == EMPTY)
            MoveBlock(bx, by, bx - 1, by); // 왼쪽 조사 => (bx, by)의 image를 (bx - 1, by)로 이동
        else if (bx < COUNT - 1 && state[by, bx + 1] == EMPTY)
            MoveBlock(bx, by, bx + 1, by); // 오른쪽 조사
        else if (by > 0 && state[by - 1, bx] == EMPTY)
            MoveBlock(bx, by, bx, by - 1); // 윗쪽 조사
        else if (by < COUNT - 1 && state[by + 1, bx] == EMPTY)
            MoveBlock(bx, by, bx, by + 1); // 아랫쪽 조사
        else {
            // 4방향 모두 이동할 수 수없다면 "삑"
            SystemSounds.Beep.Play();
            return;
        }

        // 블럭이 이동되었다면 "다 맞추었는지 확인해야 함"
        // IsComplete(); // 복습시 이 함수 만들어 보세요
    }

    public void MoveBlock(int x, int y, int tx, int ty) {
        // 1. Grid의 x, y 위치에 있는 image 객체의 참조 얻기
        //var img = grid.GetChild(x, y); // 이런 메소드가 없음

        // Grid 의 모든 자식을 순회 하면서 조사할수 밖에 없습니다.
        // => 이부분이 Grid 의 단점
        Image img = null;

        foreach(var e in grid.Children) {
            Image i = (Image)e;
            if (Grid.GetRow(i) == y && Grid.GetColumn(i) == x)
                img = (Image)e;
        }

        // 2. image 객체의 Grid 위치 속성을 tx, ty 로 변경
        Grid.SetRow(img, ty);
        Grid.SetColumn(img, tx);

        // 3. state 배열의 상태도 변경해야 함
        // state[y, x] <=> state[ty, tx]를 서로 교환
        int tmp = state[y, x];
        state[y, x] = state[ty, tx];
        state[ty, tx] = tmp;
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