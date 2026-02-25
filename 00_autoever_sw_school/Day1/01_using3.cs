// using2.cs, using3.cs 모두 빌드 포함, 나머지 제외

Console.WriteLine("Hello"); // A
WriteLine("Hello");         // B

// using2.cs를 빌드에서 제외하면, B에서만 에러가 발생하고, A에서는 발생하지 않음

// => C#10.0 부터 obj/debug/net.10/프로젝트이름.GlobalUsing.g.cs 파일 자동생성됨
//    이안에 "global using" 소스 있음.
//    컴파일시 같이 컴파일됨.