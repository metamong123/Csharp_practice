using static System.Console;

// 핵심
// => C# 의 모든 변수는
// 1. 데이타(값)을 저장하고
// 2. 데이타 관련 메소드(method, 함수)를 제공하고
// 3. 데이타 관련 속성(property) 를 제공한다.

// #1. 모든 변수는 데이타를 저장한다
int n = 10;
string s = "abcd";

// #2. 모든 변수는 자신이 저장한 데이타 관련 메소드(함수)를 제공한다.
string s2 = n.ToString();    // n이 가진 값을 문자열로 변경해서 반환
bool b1 = s.Contains("txt"); // 데이터 안에 "txt"가 포함되었는지 확인

string s3 = 10.ToString();   // 리터럴에도 메소드가 있음

// #3. 모든 변수는 자신이 저장한 데이타 관련 속성(property) 제공한다.
int n = s.Length; // s가 보관하는 문자열의 길이