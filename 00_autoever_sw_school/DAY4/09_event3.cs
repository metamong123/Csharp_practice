using static System.Console;

delegate void Handler();

class Button {
    // event가 없으면: =, +=, -= 모두 사용 가능
    // event가 있으면: +=, ==만 가능, = 안됨
    public event Handler Click = null;

    public void UserPressButton() {
        if (Click != null) Click();
    }
}

class Program {
    public static void Main() {
        Button btn1 = new Button();

        //btn1.Click = Foo;
        btn1.Click += Goo;
        //btn1.Click = Goo; // 이전에 등록한 함수가 모두 제거됨

        btn1.UserPressButton();
    }
    public static void Foo() { WriteLine("Foo"); }
    public static void Goo() { WriteLine("Goo"); }
}