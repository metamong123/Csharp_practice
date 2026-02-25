using System.Reflection.Metadata.Ecma335;
using static System.Console;

class Point {
    private int x = 0;
    private int y = 0;
    public Point(int a, int b) => (x, y) = (a, b);

    public override bool Equals(object? obj) {
        Point pt = (Point)obj;
        return pt.x == x && pt.y == y;
    }

    // ==, != 등의 연산자를 다시 만드는 것도 가능
    public static bool operator ==(Point pt1, Point pt2) {
        return pt1.x == pt2.x && pt1.y == pt2.y;
    }
    // ==을 만들면 반드시 !=도 만들어야 함!
    public static bool operator !=(Point pt1, Point pt2) { return !(pt1 == pt2); }
}

class Program {
    public static void Main() {

        Point p1 = new Point(1, 2);
        Point p2 = new Point(1, 2);

        // 동일 객체인지 조사
        // == 연산자 사용: 대부분 의도대로 동작하지만
        //                그렇지 않을 수도 있음
        Console.WriteLine($"{p1 == p2}"); // False, 재정의 안한 경우
                                          // True, 재정의한 경우
        bool b = MyReferenceEqual(p1, p2);
        Console.WriteLine(b);
    }

    public static bool MyReferenceEqual(object o1, object o2) {
        // 핵심
        // p1 == p2: Point 타입이므로 Point가 재정의한 == 사용
        // o1 == o2: Object 타입이므로 C#의 기본 동작(동일 객체 비교)
        return o1 == o2;
    }
}