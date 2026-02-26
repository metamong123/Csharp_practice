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

namespace Sample2 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
        private void Slider_ValueChanged(object sender, RoutedEventArgs e) {
            btn1.FontSize = sd1.Value;
        }
    }
}

//1.Grid 대신 StackPanel 로 변경
//2. StackPanel 에 Button  1개 , Slider 1개 만드세요 
//3. Button 은 Content="OK"
//4. Slider Minimum="10", Maximum = "200"

//5. slider 움직일때 Button 의 FontSize 가 slider 의 값으로 변경되게 해보세요