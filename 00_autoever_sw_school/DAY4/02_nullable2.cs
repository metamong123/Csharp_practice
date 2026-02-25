using static System.Console;

// 58 page

// int  : 정수 한개 보관
// int? : 정수 한 개 + bool 보관(값 있음/없음)

// 위 주석을 참고해서 아래 변환 관계를 생각해보자

// #1. int? = int
//    5byte = 4byte
int n = 0;
int? n1 = n; // ok. hasValue = true, value = 0)

// #2. int <= int?
//   4byte <= 5byte(value + bool)
int n2 = (int)n1; // ok.
                  // 1. n1 != null이면 문제 없음
                  // 2. n1이 null이면 예외 발생

// #3. int?의 값을 안전하게 int로 옮기기
if (n1 != null) { int n3 = (int)n1; } // 조사했으므로 항상 안전

int n4 = n1.GetValueOrDefault(9); // n1 == null이면 9 반환,
                                  // n1 !- null이면 value
int n5 = n1.GetValueOrDefault();  // n1 == null이면 0 반환