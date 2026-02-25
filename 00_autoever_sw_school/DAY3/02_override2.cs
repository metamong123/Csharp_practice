using static System.Console;

class Animal {
    public void Cry() { WriteLine("1. Animal Cry"); }
}
class Dog: Animal {
    public new void Cry() { WriteLine("2. Dog Cry"); }
}

class Program {
    public static void Main() {
        Animal a = new Animal();
        Dog    d = new Dog();

        Animal ad = d;

        // 핵심: 아래 한 줄은 어떤 함수를 호출?
        ad.Cry(); // 1. Animal Cry
    }
}

// ad.Cry()를 어떤 함수와 연결할 것인가?
// => Function(Method) Binding (104 page ~)

// 1. static binding: 컴파일 시간에 컴파일러가 어떤 함수를 호출할지 결정
                   // [핵심] 컴파일 시간에는 대상체의 타입은 알 수 없다
                   // 컴파일러가 알 수 있는 것은 ad 자체의 타입이 Animal이라는 것
                   // 따라서, 컴파일러가 결정하면 실제 객체 타입이 아닌
                   // Reference 타입으로 호출하여 "Animal Cry" 호출
                   // => 빠르지만, 비논리적(객체가 Dog이지만 Animal 호출)
                   // => C++, C#의 기본 바인딩 정책

// 2. dynamic binding: 컴파일 시간에는 "ad"가 가리키는 메모리를 조사하는
                    // 기계어(IL) 코드를 생성해놓고,
                    // 실행시간에 메모리를 조사해서 호출을 결정
                    // 대상체가 Dog 타입이라면 Dog Cry 호출
                    // => 느리지만 논리적
                    // => Java, Python, Kotlin, Swift 등 대부분의 객체지향 언어의 기본 바인딩
                    // => C++, C#의 virtual method를 이용하여 구현