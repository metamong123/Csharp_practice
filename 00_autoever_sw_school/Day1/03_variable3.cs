// 핵심 : 변수의 초기값을 지정하는 방법

int n1;		// 초기화 안됨.


// 변수를 초기화하는 다양한 방법
// 다음 코드는 모두 동일한 코드
int n2 = 0;
int n3 = new int();    // 위와 동일(int의 초기값은 0, 모든 타입은 디폴트값이 존재)

int n4 = default(int); // ok.
int n5 = default;	   // ok. 좌변의 int로 추론 가능

var v1 = default(int); // ok. 우변의 int로 추론 가능
var v2 = default;	   // error. 타입을 추론할 정보가 없음

// C#의 단점
// 하나의 작업을 수행할 때, 방법이 너무 많음
// 차이가 뭐고, 어떤 방식이 좋은지 혼란스러움
// int n2 = 0이 최선, 필요에 따라 다른 방식 채용