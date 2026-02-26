using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sample1 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("button4 click");
        }

        private void Button1_Click(object sender, RoutedEventArgs e) {
            button3.Content = "Hello";

            MessageBox.Show("button1 click");
        }
    }
}

// WPF Wizard 사용 시
// 프로젝트에서 보이는 cs파일은 사용자가 이벤트 처리를 위해
// 반드시 필요한 부분만 보이고
// 숨겨진 파일이 있음