using static System.Console;

// try parse 
class Program
{
	public static void Main()
	{
        // #1. int.Parse() : 문자열을 정수로 변경
        int n1 = int.Parse("10");    // ok. 성공
        int n2 = int.Parse("Hello"); // 실패. 예외 발생


        // #2. int.TryParse()
    }
}