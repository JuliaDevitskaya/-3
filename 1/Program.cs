/*Задача 19.

Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

using static System.Console;
Clear();

WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(ReadLine());
int a = number / 10000;
int b = number % 10;
int c = number / 1000 % 10;
int d = number % 100 / 10;
if (a == b && c == d)
{
    WriteLine("Число является палиндромом");
}
else
{
    WriteLine("Число не является палиндромом");
}
