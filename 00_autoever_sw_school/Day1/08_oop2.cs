using static System.Console;

// C#/C++/java 모두 객체지향 언어

// 객체지향 언어의 핵심
// => 프로그램에서 필요한 타입을 먼저 만들고
// => 만들어진 타입을 사용해서 코드 작성

// 타입을 만들 태 사용하는 키워드: class, struct
class Rect {
    // 사각형 한 개를 표현하는 데이터
    // => 필드(field)
    public int left;
    public int top;
    public int right;
    public int bottom;

    // 사각형과 관련된 기능을 수행하는 함수
    // => 메소드(Method)
    public int GetArea() {
        // 이 안에서는 자신의 필드를 마음대로 접근 가능
        return (right - left) * (bottom - top);
    }
}

// Top-Level 방식: 편하지만 class 문법을 사용할 때 제약이 많음
// => 실전에서는 Main 함수를 만드는 방식으로 수행

class Program {
    public static void Main() {
        Rect rc = new Rect(); // new Rect(1, 1, 10, 10)
        rc.left = 1;
        rc.top = 1;
        rc.right = 10;
        rc.bottom = 10;

        int area = rc.GetArea();
        WriteLine(area);
    }
}