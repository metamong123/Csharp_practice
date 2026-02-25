using static System.Console;

// 핵심 8. virtual vs non-virtual

class Shape {
    private int color = 0;

    // virtual vs [non-virtual]
    // virtual로도 가능하지만,
    // 굳이 필요하지 않는 경우에는 non-virtual을 사용해서 성능 확보
    public void SetColor(int c) { color = c; }

    // 도형의 면적을 구하는 방법은 도형마다 다름
    // => 아래 메소드는 파생 클래스가 override하게 되고
    // => 이때, override 된 메소드가 불리게 하려면 virtual 사용
    public virtual int GetArea() { return 0; }

    public virtual void Draw() { WriteLine("Draw Shape"); }

    public virtual Shape Clone() {
        Shape s = new Shape();
        s.color = color;
        return s;
    }
}

class Rect : Shape {
    public override void Draw() { WriteLine("Draw Rect"); }
    public override Shape Clone() { return new Rect(); }
}

class Circle : Shape {
    public override void Draw() { WriteLine("Draw Circle"); }
    public override Shape Clone() { return new Circle(); }
}

class Program {
    public static void Main() {
        List<Shape> s = new List<Shape>();

        while (true) {
            int cmd = int.Parse(ReadLine());
            if (cmd == 1) s.Add(new Rect());
            else if (cmd == 2) s.Add(new Circle());
            else if (cmd == 9) { foreach (var e in s) e.Draw(); }
            else if (cmd == 8) {
                WriteLine("몇 번째 만들었던 도형을 복제할까요? >>");
                int k = int.Parse(ReadLine());
                s.Add(s[k].Clone());
            }
        }
    }
}