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

namespace Sample4 {
    /// <summary>
    /// Sketch.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Sketch : Window {
        public Sketch() {
            InitializeComponent();
        }

        private Point ptfrom;

        private void canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            // 마우스 클릭 시 좌표 보관
            ptfrom = e.GetPosition(this);
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e) {
            // 선 객체를 만들어서 canvas의 자식으로
            if (e.LeftButton == MouseButtonState.Pressed) {
                Line line = new Line();
                line.Stroke = new SolidColorBrush(Colors.Red);
                line.StrokeThickness = 5;

                Point to = e.GetPosition(this);

                line.X1 = ptfrom.X;
                line.Y1 = ptfrom.Y;
                line.X2 = to.X;
                line.Y2 = to.Y;

                // Canvas에 자식으로 추가
                canvas.Children.Add(line);

                ptfrom = to;
            }
        }

        private void canvas_MouseRightButtonDown(object sender, MouseButtonEventArgs e) {
            canvas.Children.Clear();
        }
    }
}
