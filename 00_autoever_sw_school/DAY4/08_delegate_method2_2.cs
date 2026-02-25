using static System.Console;

delegate void MyFunc(int arg);

class Program {
    public static void SMethod(int arg) => WriteLine("SMethod");
    public void IMethod(int arg) => WriteLine("IMethod");

    public static void Main() {
        // 자신의 static method인 SMethod 등록
        MyFunc f1 = Program.SMethod; // ok
        MyFunc f2 = SMethod;

        // 인스턴스 메소드 등록은 "객체"가 필요
        // 현재 Main() 안에서는 객체(this)가 없다
        //MyFunc f3 = IMethod; // error. Main 인자는 this가 없다
                               // 그래서 자동으로 추가될 수도 없다
        Program pg = new Program();
        MyFunc f3 = pg.IMethod;

        pg.Foo(); //Foo(pg)
    }

    public void Foo() { // void Foo(Program this)
        // 인스턴스 메소드이므로, 호출되었다는 것은 이미 객체가 생성되었다는 것
        // => this 사용 가능
        MyFunc f4 = IMethod; //ok
        MyFunc f5 = this.IMethod; //ok
    }
}