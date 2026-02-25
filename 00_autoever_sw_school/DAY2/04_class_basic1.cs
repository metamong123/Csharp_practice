using static System.Console;

class Rect {
    // 타입을 표현하기 위해 필요한 데이터
    // C#, Java, Rust: Field 라는 용어 사용
    // C++           : member라는 용어 사용
    public int left = 0;
    public int top = 0;
    public int right = 0;
    public int bottom = 0;

    // 타입이 제공하는 함수
    // C#, Java, Rust: method라는 용어 사용
    // C++           : member 함수
    public int GetArea() {
        return (right - left) * (bottom - top);
    }

}

class Program {
    public static void Main() {
        // 사용자 타입의 변수를 만들 때는 new 사용
        Rect rc = new Rect();
        rc.left = 1;
        rc.top = 1;
        rc.right = 10;
        rc.bottom = 10;

        int ret = rc.GetArea();

        Console.WriteLine($"{ret}"); 
    }
}