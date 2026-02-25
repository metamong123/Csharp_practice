using System.Text;

// Java, C#, Swift에서 문자열 타입은 2종류가 있음
// 1. immutable string
// 2. mutable string

string s1 = "ABC"; // immutable, 변경 불가
StringBuilder s2 = new StringBuilder("XYZ"); // mutable, 변경 가능
                                             // 단축 표기법 없고, new만 가능

//s1[0] = 'X' // error. immutables
s2[0] = 'X'; // ok.