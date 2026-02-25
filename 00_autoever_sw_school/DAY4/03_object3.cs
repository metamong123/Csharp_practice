using System;

// 현재 클래스 계층도
// Rect   => Shape => Object
// Circle => Shape => Object

// Object의 역할: 모든 C# 타입의 공통 기능을 제공(GetType()등의 타입 조사 기능)
// Shape의  역할: 도형으로서 가져야 하는 공통의 특징(Draw(), GetArea())
// Rect의   역할: 사각형 자체의 특징(left, top, right, bottom)

// 객체지향 언어를 잘하려면
// 1. 문법을 정확히 이해
// 2. 라이브러리악 왜 계층별로 설계되었는지,
//    각 계층의 역할은 무엇인지 이해

abstract class Shape {
    public abstract void Draw();
}

class Rect: Shape {
    public override void Draw() { }
}

class Circle: Shape {
    public override void Draw() { }
}

class Program {
    public static void Main() {
        List<Rect> list = new List<Rect>(); // Rect만 보관 가능

        // 모든 도형을 같이 보관하려면
        // #1. Object 타입으로 보관
        // => 단점 1: Object 안에는 Draw()가 없다. Object 타입으로 호출 안됨
        //           호출하려면 캐스팅이 필요하고, 복잡해짐
        // => 단점 2: int, double도 보관 가능
        List<object> s1 = new List<object>();

        // #2. 모든 도형의 공통의 특징을 담은 Shape를 만들고, Shape 타입으로 보관
        // => 장점 1: 모든 도형의 공통의 특징을 Shape 타입으로 모두 사용 가능
        // => 장점 2: int, double 등은 보관 안됨. 안전(실수 방지)
        List<Shape> s1 = new List<Shape>();
    }

    public static void PrintHierachy(object obj) {
        Type t = obj.GetType();

        while (true) {
            Console.Write(t.Name);

            if (t.Name == "Object") break;

            Console.Write(" -> ");
            t = t.BaseType;
        }
        Console.WriteLine(""); // 개행
    }
}