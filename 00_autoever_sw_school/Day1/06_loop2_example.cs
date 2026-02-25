// 사용자가 "Q"를 입력하면 종료, 그렇지 않으면 다시 입력 받아라

using static System.Console;

string s1;

do {
    Write("input command => ");
    s1 = ReadLine();
} while (s1 != "Q");