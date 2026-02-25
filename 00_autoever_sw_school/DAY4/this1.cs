using static System.Console;

class Point {
    private int x = 0;
    private int y = 0;
    public Point(int a, int b) => (x, y) = (a, b);

    // 사용자 코드                   // 컴파일러가 변경한 코드
    public void Set(int a, int b) { // void Set(Point this, int a, int b) {
        x = a;                      // this.x = a;
        y = b;                      // this.y = b;
    }                               // }

    // 메소드 안에서 사용하는 this
    // => 현재 메소드를 호출할 때 사용한 객체와 동일
}

class Program {
    public static void Main() {
        Point p1 = new Point(1, 2);
        Point p2 = new Point(1, 2);

        // 아래 코드의 정확한 원리를 생각해보자
        p1.Set(10, 20); // Set(p1, 10, 20)
        p2.Set(10, 20); // Set(p2, 10, 20)
    }
}

// 메소드 만들 때
// C++, Java, C#: 사용자가 객체 인자를 받는 코드를 만들지 않음
// => 컴파일러가 추가

// Python, Rust: 사용자가 직접 객체 인자를 표기
// => self