using static System.Console;

class CPoint
{
	public int x;
	public int y;
	public CPoint(int a, int b) { x = a; y = b;}
}
struct SPoint
{
	public int x;
	public int y;
	public SPoint(int a, int b) { x = a; y = b; }	
}

class Program 
{
	public static void Main()
	{
		CPoint cp1;
		SPoint sp1;
		SPoint sp2 = new SPoint(1, 1);
		
		// 핵심 : 에러를 모두 찾으세요
		int a = cp1.x;	// ?
		cp1.x = 2;		// ?

		int b = sp1.x;	// ?
		sp1.x = 2;		// ?
		int c = sp1.x;	// ?

		int d = sp2.x;	// ?
		sp2.x = 2;		// ?

	}
}
