using static System.Console;

class Camera {
    public void Take() { WriteLine("take picture");  }
}

class HDCamera {
    public void Take() { WriteLine("take HD picture"); }
}

class Person {
    public void UseCamera(Camera c) {  c.Take(); }
    public void UseCamera(HDCamera c) { c.Take(); }
}

class Program {
    public static void Main() {
        Person p = new Person();
        Camera c = new Camera();

        p.UseCamera(c);

        HDCamera h = new HDCamera();
        p.UseCamera(h); //
    }
}

// 새롭게 추가된 HDCamera 때문에 기존에 있던 Person 클래스가 수정됨
// => OCP를 만족하지 않는 코드