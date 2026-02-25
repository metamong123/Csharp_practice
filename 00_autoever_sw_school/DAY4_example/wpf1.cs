using System;
using System.Windows;
using System.Windows.Controls;

class MainWindow: Window {

}

class Program {
    [STAThread]
    public static void Main() {
        MainWindow w = new MainWindow();
        Application app = new Application();
        Button b1 = new Button();
        Slider s1 = new Slider();

        PrintHierachy(w); // MainWindow 클래스 계층도
        PrintHierachy(b1);
        PrintHierachy(s1);
        PrintHierachy(app);

        w.Show();
        app.Run();
    }

    public static void PrintHierachy(object obj) {
        Type t = obj.GetType();

        while (true) {
            Console.Write(t.Name);

            if (t.Name == "Object") break;

            Console.Write(" -> ");
            t = t.BaseType;
        }
        Console.WriteLine(""); // 개행
    }
}