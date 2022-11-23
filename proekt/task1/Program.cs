﻿int InputNumber(string input)
{
     Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
 }

 void PrintSum(int m, int n, int sum)
 {
     sum = sum + n;
     if (n <= m)
    {
         Console.Write($" {sum} ");
         return;
     }
     PrintSum(m, n - 1, sum);

 }
 int m = InputNumber("Ввод m: ");
 int n = InputNumber("Ввод n: ");
 int temp = m;

 if (m > n)
 {
     m = n;
     n = temp;
 }
 Console.Write($"{m}, {n} ->");
 PrintSum(m, n, temp = 0);
