using static System.Console;

// 핵심 : 어떤 타입이 "value type" 인지 "reference type"
//        인지를 정확히 알아야 한다.

int n1 = 10; // value type
int n2 = n1; // value type

n1 = 20;
WriteLine($"{n1} {n2}"); // 20  10

int[] x1 = {1, 2, 3}; // reference 타입
int[] x2 = x1;

x1[0] = 20;
WriteLine($"{x1[0]} {x2[0]}");	// 20 20

string s1 = "AB"; // reference 타입
string s2 = s1;

s1 = "XY";
WriteLine($"{s1} {s2}");  // "XY" "AB"