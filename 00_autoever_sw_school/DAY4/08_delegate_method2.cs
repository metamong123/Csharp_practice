using static System.Console;

delegate void MyFunc(int arg);

class Program
{
    public static void SMethod(int arg) => WriteLine("SMethod");
    public        void IMethod(int arg) => WriteLine("IMethod");

    public static void Main()
    {
        // 자신의 static method 호출하기

    }

	public void InstanceMethod()
	{
	}
}
