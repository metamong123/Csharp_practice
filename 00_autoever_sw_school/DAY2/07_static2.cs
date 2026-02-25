using static System.Console;

// 방법 2. static field

class Car {
    private int speed = 0;
    private int color = 10;

    //public int cnt = 0;
    public static int cnt = 0; // static field
                               // 모든 객체가 공유하는 필드를 만들 때 사용
                               // 1. Car 객체가 한 개도 없어도 메모리에 존재
                               //    (최초 프로그램 실행시 메모리 할당)
                               // 2. Car 객체를 생성할 때, static field는
                               //    객체 개별 메모리에 포함되지 않음
                               // 3. 프로그램에서 접근할 때는 "클래스이름.필드"
                               //    "Car.cnt"

    public Car(int s) {
        speed = s;
        ++cnt;
    }
}

class Program {
    public static void Main() {
        // Car 객체가 없어도 static filed는 메모리에 존재
        // public에 있다면 "Car.cnt" 이름으로 접근 가능
        WriteLine($"{Car.cnt}"); // 출력: 0

        Car c1 = new Car(50);
        Car c2 = new Car(80);

        WriteLine($"{Car.cnt}"); // 출력: 2
    }
}

// 핵심
// instance field: 객체 각각에 대한 특징을 나타내는 데이터
//                 => e.g. 자동차의 속도(speed)는 자동차마다 다름

// static field  : 타입 자체에 대한 특징. 동일 타입의 모든 객체가 공유
//                 => e.g. 자동차의 개수