using static System.Console;

class Label 
{
	private string title;
	
	public Label(string s) => title = s;

}

class Program 
{
	public static void Main()
	{
		Label d1 = new Label("GOOD");
		Label d2 = new Label("BAD");

		// 사용자 정의 타입인 Label 도 크기 비교가 되도록 해봅시다.
		int ret = d1.compare_to(d2);
	}
}

