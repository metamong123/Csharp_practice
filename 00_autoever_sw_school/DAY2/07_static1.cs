using static System.Console;
// static 개념: 객체지향 언어의 핵심

// Car 객체(자동차)를 몇 대나 만들었는지 알고 싶다

// 방법 1. 일반 필드 cnt 사용
// => 모든 객체는 만들때 생성자가 호출된다.
// => cnt라는 필드를 만들고,
// => 생성자에서 ++하자

class Car {
    private int speed = 0;
    private int color = 10;

    public int cnt = 0; // 이렇게 만들면 모든 자동차 객체에 대해서
                        // 각각의 메모리에 놓이게 됨

    public Car(int s) {
        speed = s;
        ++cnt;
    }
}

class Program {
    public static void Main() {
        Car c1 = new Car(50);
        Car c2 = new Car(80);

        WriteLine($"{c1.cnt}"); // 출력: 1
    }
}