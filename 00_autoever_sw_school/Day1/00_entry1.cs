// C# 언어
// 소스코드 확장자: .cs
// 파일 포맷     : UTF-8 권장, 다른 포맷도 가능
// 소스 스타일   : C/C++과 유사, 문장의 끝에 반드시 세미콜론(;) 필요, 대소문자 구별

// entry point(프로그램 실행시 소스코드에서 처음 실행되는 지점)
// 1. 클래스를 한 개 만들고, Main이라는 static 메소드 제공(전통적인 방식)
// 2. Top-Level Programming 방식: 소스코드의 첫 번째 문장부터 실행(파이썬과 동일)

// 빌드 작업: 파일 속성 - C# 컴파일러(빌드에 포함) <-> 없음(빌드에서 제외)

// 아래 코드는 1번 방식
class Program {
    public static void Main() {
        System.Console.WriteLine("hello, C#");
    }
}