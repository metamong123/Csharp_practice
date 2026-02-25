// 핵심 : switch expression

int dayofweek = 1;

string s1 = "";

// 일반적인 방식의 switch 사용 
// => C/C++/Java 와 유사
switch (dayofweek)
{
	case 0: s1 = "sun"; break;
	case 1: s1 = "mon"; break;
	case 2: s1 = "tue"; break;
	default : s1 = "unknown"; break;
}

// switch expression
// => 변수 초기화를 위해 switch 사용
// => 요즘 유행하는 문법. Rust, Swift 등 비교적 최신 언어에서 널리 사용됨
string s2 = dayofweek switch {
                0 => "sun",
                1 => "mon",
                2 => "tue",
                _ => "unknown", // _는 생략할 수 없음
            };