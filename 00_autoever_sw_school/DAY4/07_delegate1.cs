using System;
using static System.Console;

// delegate 문법: 다른 언어에는 없는 C#만의 특징
class Program {
    public static void Main() {
        // ? 채워 보세요
        ? n = 3;      // 정수 3을 보관하는 타입은 int
        ? s = "ABCD"; // 문자열 "ABCD"를 보관하는 타입은 string

        ? f = Foo;      // 메소드의 호출 정보를 보관하는 타입이 필요
                      // (C언어의 함수 포인터 개념)
                      // => delegate
    }

    public static void Foo(int arg) {
        WriteLine($"Foo : {arg}");
    }
}