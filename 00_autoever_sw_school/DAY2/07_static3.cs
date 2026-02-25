using static System.Console;

// 핵심: static method

class Car {
    private int speed = 0;
    private int color = 10;

    private static int cnt = 0; // 외부에서 직접 접근 불가능

    //public int GetCount() { return cnt; } // instance method
                                            // "객체.메소드()"로 호출
                                            // 반드시 객체가 있어야 호출 가능

    public static int GetCount() { return cnt; } // static method
                                                 // 객체 없이 호출 가능한 메소드
                                                 // "클래스이름.메소드()"로 호출

    public Car(int s) {
        speed = s;
        ++cnt;
    }
}

class Program {
    public static void Main() {
        WriteLine($"{Car.GetCount()}");

        //Car.cnt = 100; // 외부에서 수정이 불가능해야 함

        Car c1 = new Car(50);
        Car c2 = new Car(80);

        WriteLine($"{Car.GetCount()}");
    }
}