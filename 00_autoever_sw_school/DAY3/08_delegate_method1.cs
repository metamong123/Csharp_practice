using static System.Console;

delegate void MyFunc(int arg);

class Test
{
    public static void SMethod(int arg) => WriteLine("Test.SMethod");
    public        void IMethod(int arg) => WriteLine("Test_Object.IMethod");
}

class Program
{
    public static void Main()
    {
        Test t = new Test();

        t.IMethod(1);    // instance method는 객체이름으로 호출
        Test.SMethod(1); // static method는 클래스 이름으로 호출
        


        MyFunc f1 = ?;  
        MyFunc f2 = ?;  

        f1(10); 
        f2(10); 


    }
}
