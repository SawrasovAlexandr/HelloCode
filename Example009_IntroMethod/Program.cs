﻿int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 12;
int b1 = 34;
int c1 = 52;

int a2 = 3;
int b2 = 345;
int c2 = 89;

int a3 = 54;
int b3 = 243;
int c3 = 678;

int max = Max(
    Max(a1,b1,c1),
    Max(a2,b2,c2),
    Max(a3,b3,c3));


Console.WriteLine(max);