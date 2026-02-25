// 파이썬은 변수 선언시 타입을 표기하지 않고,
// 하나의 변수가 모든 종류의 값을 가질 수 있음 -> 안정성이 떨어짐
// (dynamic type check language)

// 대부분의 언어에서 변수에는 타입이 있음(static type check language)
int age = 10; // age에는 정수만 담을 수 있음
age = 20;
//age = "aaa"; // error

// #1. Data type
int    n = 0;
double d = 3.4;
char   c = 'A';     // 문자 한 개는 싱글 따옴표
string s = "hello"; // 문자열은 더블 따옴표

// #2. 타입 위치에 var 사용
// -> 우변의 초기값으로 컴파일러가 타입 추론
var v1 = 10;      // int v1 = 10;
var v2 = 3.4;     // double v2 = 3.4;
var v3 = "hello"; // string v3 = "hello";

// #3. literal
int a1 = 10;   // 10진수
int a2 = 0x10; // 16진수
int a3 = 0b10; // 2진수

int a4 = 1000000;
int a5 = 1_000_000; // 값이 큰 경우, _로 자리 표시 가능