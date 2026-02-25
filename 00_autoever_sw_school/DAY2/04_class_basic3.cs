using static System.Console;

class Rect {
    public int left = 0;
    public int top = 0;
    public int right = 0;
    public int bottom = 0;

    public int GetArea() {
        return (right - left) * (bottom - top);
    }

    public Rect(int x1, int y1, int x2, int y2)
        => (left, top, right, bottom) = (x1, y1, x2, y2);

    public Rect() { }
}

class Program {
    public static void Main() {
        // 핵심 : 용어
        int n = 10;
        n = 20;     // 변수(variable)

        Rect rc = new Rect(1, 1, 10, 10);

        // rc: 객체(object), 사각형 한 개를 표현

        // 객체: 세상에 존재하는 모든 사물(책상, 의자, 자동차 등)
        //       rc는 메모리에 존재하는 사각형 한 개

        // n도 객체라고 표현해도 틀리지 않지만,
        // 언어 자체가 제공하는 타입(primitive type)을 변수라고 부르고,
        // class(struct) 문법으로 만든 타입을 객체라고 부르는 것이 관례

        int ret = rc.GetArea();

        Console.WriteLine($"{ret}");
    }
}