﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Write("Введите числа через пробел: ");
// int[] number = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int count = 0;
// for (int i = 0; i < number.Length; i++)
// {
// if (number[i] > 0)
// {
// count++;
// }
// }
// Console.WriteLine($"Кол-во элементов > 0: {count}");
//-----------------------------------------------------------------------------------------------

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения 
// b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, 
// k1 = 5, 
// b2 = 4, 
// k2 = 9 -> (-0
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());


double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;

x = Math.Round(x, 3);
y = Math.Round(y, 3);

Console.WriteLine($"Пересечение в точке: ({x};{y})");
