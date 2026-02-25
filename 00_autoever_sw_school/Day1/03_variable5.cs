// casting
double d = 3.8;
//int n1 = d;		// error. 데이터 손실이 발생하는 변환은 에러 발생

int n2 = (int)d; // ok. 명시적 캐스팅, 3으로 초기화(버림)

WriteLine(n2); // 3