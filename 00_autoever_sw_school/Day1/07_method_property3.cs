using static System.Console;

// 사용자에게 double 값 한개를 입력받아서 화면 출력해 보세요

Console.Write("Input double: ");
double d1 = double.Parse(Console.ReadLine());
//double d1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"{d1} x 3 = {d1 * 3}");