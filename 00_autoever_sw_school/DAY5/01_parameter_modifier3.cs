using static System.Console;

class Example
{
    public static void no_modifier_parameter(int x)
    {
        int n = x; // ok
        x = 0;     // ok

    }

    // out 파라미터: 참조 x에 담기만 하겠다는 의도
    //              따라서, Main에서 초기화 안된 변수를 보낼 수도 있다
    public static void out_parameter(out int x)
    {
        //int n = x; // error. 읽기 작업 불가능
        x = 0;       // ok.
    }

    // ref: Main에서 전달 시 반드시 초기화된 것만 전달 가능
    public static void ref_parameter(ref int x)
    {
        // R/W 모두 가능
        int n = x; // ok
        x = 0;     // ok
    }
}

class Program
{
	public static void Main()
	{
		int n1;		
		int n2 = 0; 

        Example.out_parameter(out n1); 
        Example.out_parameter(out n2); 

        Example.ref_parameter(ref n1); 
        Example.ref_parameter(ref n2); 

        Example.out_parameter(out int n3); 
	}
}