using static System.Console;

// #1. tuple 생성
(int, int, int)       t1 = (1, 2, 3);
(int, double, string) t2 = (1, 3.4, "ABC");

// #2. 요소 접근
var t3 = (1, 2, 3);
t3.Item1 = 10;

Console.WriteLine("{0}, {1}", t3.Item1, t3.Item2);

// #3. Named Member
(int, int, int)               v3 = (1, 2, 3); // unnamed tuple
(int one, int two, int three) v4 = (1, 2, 3);// named tuple

Console.WriteLine("{0}, {1}", v3.Item1, v3.Item2);
Console.WriteLine("{0}, {1}", v4.one,   v4.two);

// #4. Named member를 만드는 방법은 2가지
(int one, int two, int three) v5 = (1, 2, 3);
(int, int, int)               v6 = (one:1, two:2, three:3);
var                           v7 = (one: 1, two: 2, three: 3);