﻿//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= num; i++)
{
    Console.WriteLine($"{num} = {i * i * i}");
}
