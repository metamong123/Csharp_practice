using static System.Console;

// 핵심 5. 모든 도형의 공통의 특징은 반드시 기반 클래스에도 있어야 함
// => 문법의 규칙이 아닌, "디자인의 규칙"
// => 모든 도형에 Draw()가 있다면 Shape에도 Draw()가 있어야
// => Shape 참조로 Draw() 호출 가능

// 핵심 6. 기반 클래스 메소드 중 파생 클래스에서 재정의되는 것은
// => 대부분 virtual method로 해야 함
// => 그래야 Shape 참조로 호출 시 Rect, Circle에서 재정의한 Draw() 호출

// 객체지향 언어의 3대 특징
// 캡슐화: 필드를 private로 보호해서 안전성 증가
// 상속  : 공통의 특징을 기반 클래스에 => List<Shape> 가능
// 다형성: OCP를 만족하는 좋은 코딩 스타일 (e.g. e.Draw() 한 줄로 다양한 도형을 그릴 수 있음)

class Shape {
    private int color = 0;

    public virtual void Draw() { WriteLine("Draw Shape"); }
}

class Rect : Shape {
    public override void Draw() { WriteLine("Draw Rect"); }
}

class Circle : Shape {
    public override void Draw() { WriteLine("Draw Circle"); }
}

class Triangle : Shape {
    public override void Draw() { WriteLine("Draw Triangle"); }
}

class Program {
    public static void Main() {
        List<Shape> s = new List<Shape>();

        while (true) {
            int cmd = int.Parse(ReadLine());
            if (cmd == 1) s.Add(new Rect());
            else if (cmd == 2) s.Add(new Circle());
            else if (cmd == 3) s.Add(new Triangle());
            else if (cmd == 9) {
                foreach (var e in s) e.Draw(); // 새로운 도형이 추가되어도 이 한 줄은 변경되지 않음
                                               // OCP를 만족하는 좋은 코드
                                               // 다형성(Polymorphism)
                                               // => 동일한 한 줄의 코드가 상황(실제 객체의 종류)에 따라
                                               //    다르게 동작하는 것(= 가상 메소드)
            }
        }
    }
}