﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите два числа: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if(a == b) Console.Write("Числа равны!");
else if (a > b) 
{
    Console.WriteLine("Максимальное число: " + a);
    Console.WriteLine("Минимальное число: " + b);
} 
else
{
    Console.WriteLine("Максимальное число: " + b);
    Console.WriteLine("Минимальное число: " + a);
}