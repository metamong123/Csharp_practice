using static System.Console;

// 핵심 2. 모든 도형이 가진 공통의 특징을 찾아 기반 클래스 Shape 생성
//         => 공통의 특징을 하나의 클래스(Shape)에서 관리할 수 있고,
//         => 모든 도형을 한 개의 컬렉션(List<Shape>)에 보관 가능

class Shape {
    private int color = 0;

}

class Rect: Shape {

    public void Draw() { WriteLine("Draw Rect"); }
}

class Circle: Shape {

    public void Draw() { WriteLine("Draw Circle"); }
}

class Program {
    public static void Main() {
        // 만들어지는 모든 도형을 보관하기 위한 컬렉선
        //List<Rect> s = new List<Rect>(); // Rect만 보관 가능
        List<Shape> s = new List<Shape>(); // 모든 도형을 보관할 수 있음

        while (true) {
            int cmd = int.Parse(ReadLine());
            if (cmd == 1) s.Add(new Rect());
            else if (cmd == 2) s.Add(new Circle());
        }
    }
}