using System;                // System 안에 있는 요소는 System 없이 사용 가능
using static System.Console; // Console의 static method는 Console 없이 사용 가능

// System : namespace 이름(파이썬의 모듈과 유사)
// Console: 클래스 이름
// Write  : Console 클래스의 static method

System.Console.Write("Hello, "); // 출력 후 개행 안함
System.Console.WriteLine("C#");  // 출력 후 개행

// using System이 있으면 다음과 같이 작성
Console.WriteLine("AAA");

// using static System.Console이 있으면 다음과 같이 작성
WriteLine("AAA");