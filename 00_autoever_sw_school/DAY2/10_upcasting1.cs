// upcasting: 객체지향 언어에서 가장 중요한 개념 중 하나
using System;

class Animal {
    public int Age { get; set; } = 0;
}

class Dog: Animal {
    public int Color { get; set; } = 0;
}

class Cat: Animal {
    public int Speed { get; set; } = 0;
}

class Program {
    public static void Main() {
        Dog r1 = new Dog(); // ok.

        //int r2 = new Dog(); // error.

        // 핵심 1. 기반 클래스 타입의 Reference로 파생 클래스 객체를 가리킬 수 있음
        // => 가능한 이유는 "메모리 그림" 참고
        // => 왜 이렇게 하는지는 나중에 예제에서...
        Animal r3 = new Dog(); // ok.

        // 핵심 2. 컴파일러는 r3가 가리키는 곳에 있는 객체의 정확한 타입을 알 수 없음
        // => Reference의 타입만 알 수 있음

        //if (사용자입력값 == 1) r3 = new Cat();

        // 핵심 3. r3로는 Animal로부터 파생된 멤버만 접근 가능
        // => Dog 고유 멤버 접근 안됨
        // 이유: 멤버(필드, 메소드) 접근이 유효한지 확인
        r3.Age   = 10; // ok.
        //r3.Color = 10; // error.

        // 핵심 4. Dog 고유 멤버에 접근하려면 Casting을 해야 함
        ((Dog)r3).Color = 10; // ok.
                              // 단, 이 경우 반드시 r3가 가리키는 곳이 Dog라는 확인이 있어야 함
                              // Dog가 아니면 runtime error
        
        // 핵심 5. Dog라는 확신이 없다면 is 연산자로 조사 후 사용
        if (r3 is Dog) {
            // r3 자체는 아직 Animal
            Dog d = (Dog)r3;
            d.Color = 10;
            Console.WriteLine("yes");
        }
    }
}