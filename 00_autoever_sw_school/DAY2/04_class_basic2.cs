using static System.Console;

// 핵심. 생성자 이야기 
class Rect {
    public int left = 0;
    public int top = 0;
    public int right = 0;
    public int bottom = 0;

    public int GetArea() {
        return (right - left) * (bottom - top);
    }

    // 생성자: 클래스 이름과 동일한 이름의 메소드
    //        변수를 생성하면 자동으로 호출
    /*
    public Rect(int x1, int y1, int x2, int y2) {
        left = x1;
        top = y1;
        rigth = x2;
        bottom = y2;
    }
    */
    // 위 코드는 다음 코드와 같음
    public Rect(int x1, int y1, int x2, int y2)
        => (left, top, right, bottom) = (x1, y1, x2, y2);

    // 생성자는 여러 개 만들 수 있음
    public Rect() => (left, top, right, bottom) = (0, 0, 0, 0);

    // 현재는 필드에 초기값이 있으므로 아래와 같이 해도 됨
    //public Rect() { }
}

class Program {
    public static void Main() {
        Rect rc = new Rect(1, 1, 10, 10); // 인자 4개 생성자 호출
        //Rect rc = new Rect();             // 인자 0개 생성자 호출

        int ret = rc.GetArea();

        Console.WriteLine($"{ret}");
    }
}