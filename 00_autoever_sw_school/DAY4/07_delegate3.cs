using System;
using static System.Console;

// delegate 만드는 방법

// #1. 함수 모양을 그대로 복사: void Foo(int arg)
// #2. 함수 이름만 원하는 이름으로 변경: MyFunc
// #3. 반환 타입 앞에 "delegate" 추가
delegate void MyFunc(int arg);

// 정확한 원리
// 1. 사용자가 위 #1 ~ #3의 규칙에 맞게 코드를 만들면
// 2. C# 컴파일러가 아래 클래스를 생성함
/*
class MyFunc: MulticastDelegate {
    // 이 안에
    // 반환 타입: void
    // 인자     : int 한 개
    // 의 함수 메모리 주소를 보관하기 위한 코드와
    // Invoke() 메소드, () 연산자 등을 모두 자동 구현
}
*/

class Program {
    public static void Main() {
        // C# 규칙: 모든 객체는 new로 만들어야 함.
        // => Delegate도 아래가 정확한 표기법
        MyFunc f2 = new MyFunc(Foo); // 정확한 표기법

        // int, double 등은 new 없이 사용하는 단축 표기법 제공
        int n = 0; // int n = new int();

        // Delegate도 다음과 같은 단축 표기법 제공
        MyFunc f = Foo;

        f(10);
        f.Invoke(10);
    }

    public static void Foo(int arg) {
        WriteLine($"Foo: {arg}");
    }
}