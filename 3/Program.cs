﻿/*Задача 23
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

using static System.Console;
Clear();
WriteLine("Введите число: ");
int n = Convert.ToInt32(ReadLine());
int a = 1;
while (a <= n)
{
    Write(Math.Pow(a, 3) + " "); //(a * a * a + " ");
    a++;
}
WriteLine();

