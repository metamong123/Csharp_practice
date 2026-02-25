// 핵심 : 초기화되지 않은 변수는 쓰기만 가능.
int n;     // 초기값 없음
int a = 0;

a = n;			// error.
WriteLine(n);	// error. 초기화되지 않은 n을 읽으려 함

n = a;	// ok. 쓰는 작업
a = n;  // ok. 읽는 작업이지만, 위 줄에서 초기화됨