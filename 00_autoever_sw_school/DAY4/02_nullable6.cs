string name1 = "ABC";
string name2 = null;

var n1 = name1.Length; // ok.
var n2 = name2.Length; // 실행시간 에러 발생

// null인 객체를 사용하는 것은 아주 위험!!
// 안전한 코드를 사용하려면 null을 사용하지 않고, 항상 값을 가지도록 구현

// value type:
// int  : null 가질 수 없음
// int? : null 가질 수 있음
// => 사용자가 null을 사용할지 말지 선택할 수 있음
// => 안전한 코드가 필요하다면 int?를 사용하지 말자

// reference type
// => ~ C#8.0: 항상 null이 될 수 있음
// => C#9.0 ~: reference type도 null 가능, 불가능을 선택할 수 있음

string  s3 = null; // null 불가능 문자열
string? s4 = null; // null 가능   문자열


