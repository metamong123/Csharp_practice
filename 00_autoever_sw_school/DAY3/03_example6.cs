using static System.Console;

class Shape {
    private int color = 0;

    public virtual void Draw() { WriteLine("Draw Shape"); }

    // 자신의 복사본을 만드는 가상 메소드는 널리 알려진 디자인 기술
    public virtual Shape Clone() {
        Shape s = new Shape(); // 새로운 Shape를 만들고
        s.color = color;       // 자신의 모든 속성을 동일하게 복사
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

                // k 번째 도형의 복사본을 생성해서 s에 추가
                // k 번째 도형은 어떤 타입?

                // 아래 코드는 OCP를 만족하지 않는 코드
                //if (s[k] is Rect) { s.Add(new Rect()); }
                //else if (s[k] is Circle) { s.Add(new Circle()); }

                // k 번째 도형이 무엇인지 알 필요 없음
                s.Add(s[k].Clone()); // k 번째 도형에 복사본 요청

                // 객체 지향 언어에서 종종 사용하는 격언
                // Dont Ask Do It (물어보지 말고, 시켜라)
            }
        }
    }
}