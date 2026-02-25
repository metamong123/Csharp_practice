// Collection 

class Program {
    public static void Main() {
        int[] arr = { 1, 2, 3, 4, 5 };

        // List<>: 크기를 변경할 수 있고, 삽입/삭제 가능
        List<int> s = new List<int>();

        s.Add(1);
        s.Add(2);
        s.Add(3);

        // 접근은 []
        s[0] = 10;
        s[1] = 30;

        // List : 편리하지만 약간 느림
        // Array: 불편하지만 List보다 빠름
    }
}