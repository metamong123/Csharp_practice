// 접근 지정자: [필드, 메소드, property]에 대한 접근은 지정하는 키워드
// => 전통적인 객체지향 문법에서는 3개
// => C++: public, private, protected(상속 문법에서만 사용)
// => 그 외 언어: 위 3개 + 각 언어에서 추가 (C#: internal)

class Shape {
    //private int color = 0;   // 자신의 메소드만 접근 가능
    //protected int color = 0; // 자신의 메소드 + 파생 클래스 메소드에서 접근 가능
    //public int color = 0;      // 모든 위치(멤버가 아닌 메소드도)에서 접근 가능
    internal int color = 0; // 동일 모듈(같은 컴파일 단위)
                            // 현재 소스를 .dll로 빌드한 후
                            // 다른 실행파일에서 DLL Load하는 경우
                            // color 접근 안됨
                            // public이라면 .exe에서 접근 가능

    public void SetColor(int c) {
        color = c;
    }   
}

class Rect : Shape {
    public void Draw() {
        int c = color; // ?
    }
}

class Program {     
    public static void Main() {
        Shape s = new Shape();
        s.color = 10; // error
    }

}

// 1. "Developer Command Prompt for VS" 실행
// 2. ILDASM(중간 언어(IL)의 Disassembly) 입력
// 3. 파일 => 프로젝트 파일 => bin\Debug\net10.0\ 의 .dll 파일 선택
// 4. 클래스의 함수를 클릭하면 중간 언어로 표현된 코드 확인 가능