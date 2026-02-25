// Top-Level 방식(Main 함수 없음)
// C# 9.0부터 지원

System.Console.WriteLine("hello, C#");

// 간단한 테스트는 Top-Level 방식 선호

//소스코드가 커지면 별도의 Entry Point가 있는 게 관리가 편하다

// Top-Level의 원리
// -> 컴파일러가 아래 코드를 생성하고 사용자가 만든 코드를 Main 안에 넣는 것
/*
class CompilerGeneratedName {
    public static void Main() {
        System.Console.WriteLine("hello, C#");
    }
}
*/