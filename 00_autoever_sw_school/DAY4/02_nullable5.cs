using static System.Console;

// null conditional operator ( ?, ?[]) 

string s1 = "hello";
string s2 = null;

var ret1 = s1.ToString(); // ok. 객체가 존재.
var ret2 = s2.ToString(); // 런타임에러(예외 발생)

// 메소드 호출 시 안전하게 하려면
// 1. s2 != null이면 ret3에 메소드 반환 결과
// 2. s2 == null이면 메소드 호출 안 되고, ret3도 null(초기화 때문)
string ret3 = null;

if (s2 != null) { ret3 = s2.ToString(); }

// 다음 한 줄이 위와 동일
string ret4 = s2?.ToString(); // <== 널리 사용되는 코드
// 1. s2 != null이면 ToString() 메소드 호출
// 2. s2 == null이면 ToString() 메소드 호출 X, null 반환

// 배열도 reference type
int[] arr = null;

int n1 = arr[0];  // error. 현재 배열 자체가 없음(null)
int n2 = arr?[0]; // error.
                  // 1. arr != null이면 arr[0] 반환
                  // 2. arr == null이면 arr[0] 접근 X, null 반환
                  // => 그런데 int n2에는 null을 담을 수 없다!

int? n3 = arr?[0]; // ok.
if (n3 != null) { }