// 인스턴스 메소드(static이 아닌 메소드)
// "객체.메소드이름()"으로만 호출 가능

// 컴파일 시 아래 한 줄이 추가되어 실행됨
// "Program.Main()"

using System.Drawing;

class Program {
    private int color = 0;

    public void F1(int a) {
        color = 10;

        Program.SF(0);
        SF(0);
    }

    public void F2(int a) { // F2(Program this, int a)
        // F2가 호출되었다는 것은 객체가 있다는 것
        // 그 객체 참조는 this
        // 그래서 여기서는 "this" 사용해서 F1 호출
        this.F1(0);
        F1(0); // 자기 자신의 메소드이므로 this 생략 가능

        Program.SF(0);
        SF(0);
    }

    public static void Main() {
        // 1. 아직 Program 객체를 만든 적이 없다
        // 2. 여기서 F1을 바로 호출할 수 없음(인스턴스 메소드인데, 객체가 없어서)
        // 3. F1을 호출하려면 객체가 필요
        Program pg = new Program();
        pg.F1(1);
        pg.F2(1);

        Program.SF(0);
        SF(0);
    }

    // static: 어느 위치에서든 "클래스이름.메소드이름()"으로 호출 가능
    //         자신의 메소드에서는 "클래스이름" 생략 가능
    public static void SF(int a) { }
}