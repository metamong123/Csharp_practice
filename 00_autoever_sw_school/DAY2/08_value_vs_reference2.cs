using static System.Console;

class CPoint {
	public int x;
	public int y;
	public CPoint(int a, int b) { x = a; y = b; }
}

struct SPoint {
	public int x;
	public int y;
	public SPoint(int a, int b) { x = a; y = b; }
}

// 핵심 : 아래 코드의 메모리 모양
class Program {
	public static void Main() {
		// 아래 코드 결과 예측 - 38 page
		CPoint cp1 = new CPoint(1, 1);
		CPoint cp2 = cp1; // heap에 있는 객체의 주소를 복사한 것
		
		cp1.x = 2;

		WriteLine($"{cp1.x} {cp2.x}"); // 2 2

		SPoint sp1 = new SPoint(1, 1);
		SPoint sp2 = sp1;

		sp1.x = 2;
	
		WriteLine($"{sp1.x} {sp2.x}");  // 2 1
    }
}