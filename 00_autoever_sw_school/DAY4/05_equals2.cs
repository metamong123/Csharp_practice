using static System.Console;

class Point {
    private int x = 0;
    private int y = 0;
    public Point(int a, int b) => (x, y) = (a, b);

    public override bool Equals(object? obj) {
        Point pt = (Point)obj;

        return pt.x == x && pt.y == y;
    }
}

class Program {
    public static void Main() {

        Point p1 = new Point(1, 2);
        Point p2 = p1;

        Point p3 = new Point(1, 2);
        Point p4 = new Point(1, 2);

        // p3, p4가 동일한 상태인지 조사하는 코드
        // ================================================
        bool b;

        b = p3 == p4; // 동일 객체인지 먼저 조사, 매우 빠르다!

        // 동일 객체가 아니라면 상태 조사
        if (b == false) { b = p3.Equals(p4); }
        // ================================================
        // 위 코드와 유사한 함수:
        // object 클래스의 Equals() static 메소드

        // p3.Equals(p4)         : instance method(virtual)
        // object.Equals(p3, p4) : static method

        bool b2 = object.Equals(p3, p4);
        // 1) b = p3 == p4 조사
        // 2) b == false 라면 p3.Equals(p4)

        Console.WriteLine($"{b}");
        Console.WriteLine($"{b2}");

        // [정리]
        // 동일 상태 조사
        bool b3 = p3.Equals(p4); // 가능하고 많이 사용되지만
                                 // 최선은 아님
        bool b4 = object.Equals(p3, p4); // 최선의 코드
    }
}