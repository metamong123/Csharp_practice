using static System.Console;

class Point {
    private int x = 0;
    private int y = 0;
    public Point(int a, int b) => (x, y) = (a, b);

    // 사용자 코드
    public void Set(int x, int y) {
        // 필드와 인자의 이름이 동일하면 가까운 것 사용
        // => 아래 코드는 인자의 x, y
        //x = x;
        //y = y;

        // this 활용 #1. 이름 충돌이 있을 때 필드임을 나타내기 위해
        // => 이름 충돌이 없어도 "this.x"로 사용하면
        //    필드임을 명확히 표현할 수 있으므로 가독성 증가
        this.x = x;
        this.y = y;
    }

    // 활용 #2. this를 반환하면 method를 연속으로 호출 가능
    public Point SetX(int x) {
        this.x = x;
        return this;
    }

    public Point SetY(int y) {
        this.y = y;
        return this;
    }
}

class Program {
    public static void Main() {
        Point p1 = new Point(1, 2);

        p1.Set(10, 20); // Set(p1, 10, 20)
        Point.Foo(1, 2); // Foo(10, 20)
    }
}

// instance method: this 추가 됨
// static   method: this 추가 안됨

// Main 메소드는 static
// => Program 객체를 만들지 않고 호출된 것
// => Main 안에서 this는 없다.
// => 객체가 필요하면 만들어야 한다.