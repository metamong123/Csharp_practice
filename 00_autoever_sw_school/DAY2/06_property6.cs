class Person {
    /*
    // #1. 필트를 만들고
    private int age;

    // #2. age에 대한 Property 작성
    // => 필드 이름의 첫 번째 글자를 대문자로 하는 것이 관례
    public int Age {
        get => age;
        set => age = value;
    }
    */

    // 위 property는 어떤 추가적인 logic 없이 값을 그대로 필드에 대입
    // 이 경우 아래 한 줄만 작성하면 됨(auto-implemented property)
    public int Age { get; set; } = 0;
    // 1. 필드가 자동으로 생성되고
    // 2. Age property 의 set, get 의 기본 구현이 자동 추가
}

class Program {
    public static void Main() {
        Person p = new Person { Age = 10 };

        Console.WriteLine(p.Age);
    }
}