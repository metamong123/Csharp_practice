class Person1 {
    // 자동 구현 property: 값의 유효성 확인 없음
    //public int Age { get; set; } = 0;

    // 위 코드가 나중에 유효성 확인을 위해 아래와 같이 변경될 수 있음
    public int age = 0;

    public int Age {
        get => age;
        set { if (value > 0) age = value; }
    }
    // 핵심: Person1의 구현이 변경되었지만, 사용자 코드는 변경될 필요 없음
}

class Person2 {
    // public 필드: 값의 유효성 확인 없음
    public int age = 0;

    // age 부분을 property로 만들게 되면
    // 외부 사용자 코드도 모두 변경되어야 함

    // => 유효성 검사가 당장 없더라도, public 필드 사용 x, auto property로 만들어야 함
}

class Program {
    public static void Main() {
        Person1 p1 = new Person1();
        Person2 p2 = new Person2();

        p1.Age = 10;
        p2.age = 10;
    }
}