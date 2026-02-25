using static System.Console;

// delegate의 용도
// => 버튼 등의 GUI에 함수를 등록하면 해당 이벤트 발생 시 등록된 함수 호출

delegate void Handler();

class Button {
    // Hander: delegate이므로, 함수 정보를 보관하는 타입
    public Handler Click = null;

    public void UserPressButton() {
        if (Click != null) Click();
    }
}

class Program {
    public static void Main() {
        Button btn1 = new Button();
        Button btn2 = new Button();

        // 버튼 누를 때 호출될 함수 등록
        btn1.Click = Foo;
        btn2.Click = Goo;

        btn1.UserPressButton(); // 등록된 함수 호출
        btn2.UserPressButton();
    }
    public static void Foo() { WriteLine("Foo"); }
    public static void Goo() { WriteLine("Goo"); }
}