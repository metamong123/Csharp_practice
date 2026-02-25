using System.Windows;
using System.Windows.Controls;

class MainWindow : Window {

    public MainWindow() {
        // Grid Panel: 엑셀처럼 격자 형태로 관리하는 Panel
        Grid grid = new Grid();
        Content = grid;

        // 1. Row, Col 값 설정
        //grid.SetRowCol(2, 3); // 일반적인 라이브러리: 2개 Column, 3개 Row

        // WPF는 독특한 방법 사용
        grid.RowDefinitions.Add(new RowDefinition());
        grid.RowDefinitions.Add(new RowDefinition());
        grid.RowDefinitions.Add(new RowDefinition());

        grid.ColumnDefinitions.Add(new ColumnDefinition());
        grid.ColumnDefinitions.Add(new ColumnDefinition());

        // 2. 컨트롤을 만들고
        Button b1 = new Button { Content = "버튼1" };
        Button b2 = new Button { Content = "버튼2" };

        // 3. 각 컨트롤이 Grid의 어디에 놓일지 설정
        // => 이 부분이 WPF 라이브러리의 독측한 코드
        Grid.SetRow(b1, 0);
        Grid.SetColumn(b1, 0);

        Grid.SetRow(b2, 2);
        Grid.SetColumn(b2, 1);

        // 4. 자식 컨트롤 부착
        grid.Children.Add(b1);
        grid.Children.Add(b2);
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