﻿int a = 15;
int b = 8;
int c = 359;
int d = 2;
int e = 68;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);