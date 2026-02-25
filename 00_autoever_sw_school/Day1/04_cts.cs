using System;

int   n1 = 0;        // int: 별명(=System.Int32)
System.Int32 n2 = 0; // System.Int32: 진짜 타입 이름

Int32 n3 = 0;        // ok.
System.int   n4 = 0; //error.

double d1 = 0;        // 별명
Double d2 = 0;        // System 생략
System.Double d3 = 0; // 정확한 표기

string s1 = "A";
String s2 = "A";
System.String s3 = "A";
