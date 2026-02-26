using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

// step7. Window 자체도 xml로
// => 모든 UI를 XML로 구축

class App: Application {
    [STAThread]
    public static void Main() {
        // =============================================================
        FileStream fs = new FileStream("../../../ui3.txt",
                                        FileMode.Open, FileAccess.Read);

        Window w = (Window)XamlReader.Load(fs);

        fs.Close();
        // =============================================================
        w.Show();

        App app = new App();
        app.Run();
    }
}