using static System.Console;

class Example
{
    public static void no_modifier_parameter(int x)
    {
        int n = x;
        x = 0;

    }

    public static void out_parameter(out int x)
    {
        int n = x;
        x = 0;
    }

    public static void ref_parameter(ref int x)
    {
        int n = x;
        x = 0;
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