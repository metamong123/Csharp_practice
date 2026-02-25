using static System.Console;

class Animal {
    public void Cry() { WriteLine("1. Animal Cry"); }
}
class Dog: Animal {
    // method override: 기반 클래스의 메소드를 파생 클래스에서 재정의하는 것
    // [Warning] new 키워드를 붙여서 실수가 아니라 의도적으로 재정의했음을 알림
    public new void Cry() { WriteLine("2. Dog Cry"); }
}

class Program {
    public static void Main()     {
        Animal a = new Animal();
        Dog d = new Dog();

        a.Cry();    // 1. Animal Cry
        d.Cry();    // 2. Dog Cry
    }
}
