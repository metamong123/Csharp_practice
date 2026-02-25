// object 이야기

// 거의 모든 타입은 자동으로 Object 라는 클래스로부터 상속받는다


class Car { // [class Car: Object]의 의미
}

class Program {
    public static void Main() {
        Car c = new Car();
        string s = c.ToString(); // 타입 이름이 문자열로 반환됨
                                 // C#의 거의 모든 변수에는 ToString() 메소드가 있다
        // Object 클래스가 가진 모든 메소드는
        // => C#의 거의 모든 변수가 갖고 있음
        // => 중요하므로, 각 메소드의 기능을 알아야 함
    }
}