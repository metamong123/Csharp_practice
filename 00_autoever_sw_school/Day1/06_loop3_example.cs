using System;

// 도전 과제
// for를 이용해서 다음과 같이 출력
//*
//**
//***
//****
//*****
Console.Write("별 개수(홀수만 입력): ");
int n = int.Parse(Console.ReadLine());

for(int i = 1; i <= n; i++) {
    for(int j = 1; j <= i; j++) Console.Write("*");
    Console.WriteLine("");
}

Console.WriteLine("======");
// *****
//  ***
//   *
//  ***
// *****
int n_stars, n_space;

for (int i = n - 1; i >= -(n - 1); i -= 2) {
    n_stars = Math.Abs(i) + 1;
    n_space = (n - 1 - Math.Abs(i)) / 2;
    for (int j = 1; j <= n_space; j++) Console.Write(" ");
    for (int j = 1; j <= n_stars; j++) Console.Write("*");
    Console.WriteLine("");
}