using static System.Console;

// 핵심 4. 해결책 1. 캐스팅
// => 가능한 해결책이지만 좋은 디자인이 아님

// OCP(Open Close Principle) 개념
// Open     : 기능 확장에 열려있고          (= 새로운 요소가 추가되어도)
// Close    : 코드 수정에는 닫혀 있어야 하는 (= 기존 코드는 수정되지 않도록)
// Principle: 이론

// 새로운 요소가 추가되어도 기존 코드는 변경되지 않도록 설계하는 것이 중요
// => 유지보수와 기능 확장을 고려해야 함

// 아래 코드는 OCP 위반
// => Triangle 추가 시 Main의 foreach에서 if문이 추가되어야 함

class Shape {
    private int color = 0;
}

class Rect : Shape {
    public void Draw() { WriteLine("Draw Rect"); }
}

class Circle : Shape {
    public void Draw() { WriteLine("Draw Circle"); }
}

class Triangle : Shape {
    public void Draw() { WriteLine("Draw Triangle"); }
}

class Program {
    public static void Main() {
        List<Shape> s = new List<Shape>();

        while (true) {
            int cmd = int.Parse(ReadLine());
            if (cmd == 1) s.Add(new Rect());
            else if (cmd == 2) s.Add(new Circle());
            else if (cmd == 9) {
                foreach (var e in s) {
                    if (e is Rect) {
                        Rect r = (Rect)e;
                        r.Draw();
                    }
                    else if (e is Circle) {
                        Circle c = (Circle)e;
                        c.Draw();
                    }
                    else if (e is Triangle) {
                        Triangle t = (Triangle)e;
                        t.Draw();
                    }
                }
            }
        }
    }
}