using static System.Console;

delegate void MyFunc(int arg);

class Program {
    public static void SMethod(int arg) => WriteLine("SMethod");
    public        void IMethod(int arg) => WriteLine("IMethod");

    // 프로그램 entry의 원리
    // 1. 모든 클래스를 조사해서 Main이라는 static method가 있는 클래스를 찾음
    // 2. static method이므로 Program 객체 만들 필요 없이
    //    "Program.Main()"을 호출해서 프로그램 실행

    public static void Main() {
        // 자신의 static method 호출하기
        // static   method: 타입이름.메소드이름()
        // instance method: 객체이름.메소드이름()

        Program.SMethod(1); // ok
        SMethod(1);         // 자신의 static 메소드인 경우, 타입 이름 생략 가능

        //this.IMethod(0); // 프로그램이 실행될 때 Program.Main()을 호출해서 객체가 생성되지 않았음
                           // => this를 사용할 수 없음

        // 인스턴스 메소드를 호출하려면 객체가 필요
        Program pg = new Program();
        pg.IMethod(1);

        pg.Foo(); // Foo(pg)
    }

	public void Foo() {
        // 여기서 Instance method 호출
        this.IMethod(1); // 정확한 표기: "객체.인스턴스메소드()"
        IMethod(1);      // 자기 자신의 Instance method를 호출할 때는 this 생략 가능

        // static method는 타입 이름으로
        Program.SMethod(1);
        SMethod(1);
    }
}