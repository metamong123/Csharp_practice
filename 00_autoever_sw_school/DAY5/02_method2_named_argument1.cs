
class Rect
{
    public void Set(int x, int y, int width, int height) { }
}

class Program
{
    public static void Main()
    {
        Rect rc = new Rect();

        // => x, y, widht, height
        // => x1, y1, x2, y2
        // 도움말이 필요
        rc.Set(1, 1, 10, 10);

        // => named argument라는 문법
        // => C#, Objective-C, Swift 등의 언어가 지원
        rc.Set(x:1, y:1, width:10, height:10);

        // 이름이 있다면 순서 변경 가능
        rc.Set(width:10, height:10, x:1, y:1);

        // 위치와 이름 인자를 섞어도 됨
        rc.Set(1, 1, width: 10, height: 10);
    }
}
