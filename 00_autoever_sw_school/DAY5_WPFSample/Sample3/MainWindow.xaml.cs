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

namespace Sample3 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
    }
}

// WPF의 구성
// 창  : MainWindow..xaml(UI) + .cs 파일(event)
// App : App.Xaml(리소스 관련) + .cs 파일(OnExit 등의 가상함수 재정의)
// => 한 개의 화면에 두 개의 파일