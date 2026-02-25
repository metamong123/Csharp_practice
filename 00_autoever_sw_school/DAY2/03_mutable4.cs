using System;

// 아래 두 줄은 완전히 동일
// => 하지만 타입에 따라서 new와 단축 표기법의 동작이 다른 경우가 있다
int n1 = 0;
int n2 = new int();

// 메모리에 "AAA"라는 문자열이 몇 개 있을까?
// => 
string s1 = "AAA"; // string intern pool에 있는 문자열을 가리키게 됨
string s2 = "AAA"; // s1과 같은 주소를 가리킴

// new를 이용하면 string intern pool을 사용하지 않고 개별 메모리를 사용함 (권장하지 않음)
string s3 = new string("AAA");
string s4 = new string("AAA");

// 2개가 같은 메모리 주소를 가리키는지 조사하는 방법
Console.WriteLine($"{object.ReferenceEquals(s1, s2)}"); // true
Console.WriteLine($"{object.ReferenceEquals(s1, s3)}"); // false

Console.WriteLine($"{s1 == s3}"); // true, 객체(주소) 비교 X, 같은 문자열인지를 조사

// StringBuilder: 변경 가능하므로, 공유할 수 없음

// 변경 불가능하면
// 1. 동일 데이터의 공유 가능
// 2. 여러 개의 CPU에서 동시에 접근해도 문제 없음(멀티 코어에 최적화됨)
// 3. 컴파일러가 다양한 방법으로 최적화 가능

// 변경할 필요 없는 문자열 => 무조건 string 사용
// => StringBuilder를 사용해도 되지만 성능이 나쁘고, 동시 접근 시 동기화 필요