using System;

class Program {
    // 메소드 인자가 object 타입이면
    // "모든 타입의 변수를 받을 수 있다"
    public static void Foo(object obj)     {
        // obj 가 어떤 타입인지 알고 싶다

        // #1. is 연산자: obj가 int 타입인지 조사
        if (obj is int) { }

        // #2. GetType() 메소드 사용
        // => GetType()은 Object에서 파생된 메소드이므로 모든 변수가 갖고 있다.

        // Type: 타입의 정보를 관리하는 타입
         Type t = obj.GetType();

        // t가 obj 변수의 타입 정보를 가진 변수
        Console.Write("{0} -> ", t.Name);
        Console.Write(t.BaseType.Name); // 부모 타입
        Console.WriteLine(""); // 개행

    }

    public static void Main() {
        int n = 10;
        double d = 3.14;

        //Foo(n);
        //Foo(d);
        //Foo("abc");

        PrintHierachy(n);
        PrintHierachy(d);
        PrintHierachy("abc");
    }

    public static void PrintHierachy(object obj) {
        Type t = obj.GetType();

        while (true) {
            Console.Write(t.Name);

            if (t.Name == "Object") break;

            Console.Write(" -> ");
            t = t.BaseType;
        }
        Console.WriteLine(""); // 개행
    }
}