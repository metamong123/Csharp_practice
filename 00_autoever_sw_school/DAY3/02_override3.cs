using static System.Console;

class Animal {
    // 일반 메소드
    // => C#의 기본 바인딩 정책인 "static binding" 사용
    // => Cry1() 메소드 호출은 컴파일 시간에 Reference 타입으로 결정
    public void Cry1() { WriteLine("Animal Cry1"); }

    // 가상(virtual) method
    // => dynamic binding을 해달라는 의미
    // => Cry2() 호출시, 컴파일 시간에 결정하지 말고
    //    실행할 때 메모리를 조사해서 메소드를 결정하라
    public virtual void Cry2() { WriteLine("Animal Cry2"); }
}

class Dog: Animal {
    // virtual method를 다시 만들 때는 "override" 키워드 사용
    public new      void Cry1() { WriteLine("Dog Cry1"); }
    public override void Cry2() { WriteLine("Dog Cry2"); }
}

class Program {
    public static void Main() {
        Animal ad = new Dog();

        // ad 자체의 타입   : Animal
        // ad가 가리키는 객체: Dog

        ad.Cry1();  // static binding  => Animal Cry1 | 컴파일 시간에 결정, 빠름
                    //                                | reference 타입으로 호출
        ad.Cry2();  // dynamic binding => Dog    Cry2 | 실행 시간에 결정, 느림
                    //                                | 대상체(reference가 가리키는 실제 객체)의 타입으로 호출

        // Java는 모든 메소드가 dynamic binding (= virtual처럼 동작)
    }
}