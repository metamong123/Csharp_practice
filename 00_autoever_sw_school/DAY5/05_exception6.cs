using static System.Console;

int age = 0;

while(true) {
    Write("나이를 입력해 주세요 >>");

    string s = ReadLine();

    try {
        age = int.Parse(s);
    }
    catch (FormatException e) {
        WriteLine("잘못 입력했습니다. 다시 입력해 주세요");
        continue; // 루프의 시작으로 이동
    }
    break;
}

WriteLine($"입력된 나이는 {age} 입니다.");