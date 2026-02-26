using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Sample3 {
    /// <summary>
    /// Second.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Second : Window {
        public Second() {
            InitializeComponent();
        }

        public First first = null;

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            // First 창을 나타내는 클래스의 이름은 "First"

            // 아래 코드는 누를 때마다 생성되는 코드
            //First first = new First();
            //first.Show();

            if (first == null) {
                first = new First();
                first.Show();
            }
        }
    }
}
