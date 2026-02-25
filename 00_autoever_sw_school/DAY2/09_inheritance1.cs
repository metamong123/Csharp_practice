// inheritance (상속)

// 모든 사람의 특징을 뽑아서 Person 타입을 설계
class Person {
    private string name;
    private int age;

    private string email; // Person의 파생 클래스에 모두 추가됨
}

// Person : Base   , Super, Parent class로 부름
// Student: Derived, Sub  , child class로 부름

// 상속(inheritance): 기존 타입을 확장해서 새로운 타입을 만드는 것
// => class만 가능, struct는 불가능

class Professor: Person {
    private string major;
}

class Student : Person {
    private string id;
}

class Program {
    public static void Main() {
        Student s = new Student();
    }
}
