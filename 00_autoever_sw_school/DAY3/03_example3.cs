using static System.Console;

// 핵심 3. 아래 코드가 에러라는 사실
// 모든 도형을 보관하기 위해 List<Shape>를 사용헸는데,
// Shape 타입으로는  Rect, Circle에서 추가한 고유 멤버에 접근할 수 없음

class Shape {
    private int color = 0;
}

class Rect : Shape {
    public void Draw() { WriteLine("Draw Rect"); }
}

class Circle : Shape {
    public void Draw() { WriteLine("Draw Circle"); }
}

class Program {
    public static void Main() {
        List<Shape> s = new List<Shape>();

        while (true) {
            int cmd = int.Parse(ReadLine());
            if (cmd == 1) s.Add(new Rect());
            else if (cmd == 2) s.Add(new Circle());
            else if (cmd == 9) {
                foreach (var e in s) e.Draw(); // error. Shape에는 Draw 메소드가 없음
            }
        }
    }
}