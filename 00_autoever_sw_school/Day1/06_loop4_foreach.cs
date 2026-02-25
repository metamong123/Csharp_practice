// for 복사
using static System.Console;

int[] x = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

// for: 개수가 명확한 경우에 사용
//for (int i = 0; i < 10; i++) {
//    WriteLine($"{x[i]}");
//}

// foreach: 배열이나 컬렉션의 모든 요소 열거(python의 for)
foreach (var e in x) { // var 권장, x의 타입이 변경되어도 코드 수정 필요 X
    WriteLine($"{x[e]}");
}