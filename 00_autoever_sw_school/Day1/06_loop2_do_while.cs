// while 복사
using static System.Console;

int cnt = 0;

// while : 조건을 조사후 실행
while (cnt < 10) {
    WriteLine("hello");
    ++cnt;
}

// do-while: 한 번 실행 후 조건 조사
cnt = 0;

do {
    WriteLine("hello");
    ++cnt;
} while (cnt < 10); // 조건이 false라도 한 번은 실행됨