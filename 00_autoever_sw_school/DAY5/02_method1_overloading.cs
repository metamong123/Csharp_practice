using static System.Console;

// function overloading
// 인자의 개수나 타입이 다른 경우(호출 코드를 보고 구별 가능한 경우)
// => 동일 이름의 함수를 여러 개 만들 수 있다.

// 장점: 함수 자체는 여러 개이지만, 사용자는 한 개처럼 보이게 됨
// => 일관된 형태의 라이브러리 구축에 효과적

class Math {
    public int Square(int x) {
        return x * x;
    }
    public double Square(double x) {
        return x * x;
    }
}

class Program {
    public static void Main() {
        Math m = new Math();

        var ret1 = m.Square(3);
        var ret2 = m.Square(3.3);

        WriteLine($"{ret1}, {ret2}");
    }
}