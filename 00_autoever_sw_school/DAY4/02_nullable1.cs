using static System.Console;

// value type: 스택에 값을 보관
// reference type: 힙에 값을 보관, stack에서 힙을 가리키는 것(포인터 변수)

// #1. reference type 의 변수는 null 로 초기화 될수 있습니다.
// => 값이 없음을 표현할 때 사용
string s1 = "hello";
string s2 = null; // ok

// #2.value type 의 변수는 null 로 초기화  될수 없습니다.
int n1 = 0;
//int n2 = null;	// error.

// #3. value type은 "값 없음"을 표기할 수 없었음
// => C# 2.0부터 value type도 값 없음을 표현하기 위해 Nullable 도입

Nullable<int> n3 = null; // ok. null 가능한 int
Nullable<double> n4 = null; // ok.

//Nullable<string> n5 = null; // error. Nullable<>은 value type에만 사용 가능


// #4. 단축 표기법
// 아래 두 줄은 동일한 표기법
Nullable<int> n5 = null;
int? n6 = null; // <== 실전에서는 이렇게 사용

// #5. Nullable의 원리 - 55 page n1, n2 그림 참고
// [1byte bool hasValue] + [4byte int value] => 5byte
// hasValue: 값이 있으면 true, 없으면 false
int n7 = 10;
Nullable<int> n8 = null;
Nullable<int> n9 = 10;