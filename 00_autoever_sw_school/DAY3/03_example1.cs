using static System.Console;

// 파워 포인트 같은 프로그램을 객체지향 프로그램으로 설계해 봅시다.

class Rect {
    // left, top, right, bottom, 생성자 등은 생략
    // virtual에 집중!

    public void Draw() { WriteLine("Draw Rect"); }
}

class Circle {

    public void Draw() { WriteLine("Draw Circle"); }
}

class Program {
    public static void Main()
    {
        Rect r = new Rect();
        r.Draw();

        Circle c = new Circle();
        c.Draw();
    }
}