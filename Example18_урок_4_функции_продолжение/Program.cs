// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Console.Write("Введите число : ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите степень: ");
// int B = Convert.ToInt32(Console.ReadLine());
// int number = A;
// int degree = B;
// int summa = 0;
// for (int i = 0; i <= degree; i++)
// {
//    
// Console.Write(Math.Pow(number, i) + " " );
//    
// }    
//---------------------------------------------------------------------    
// Задача 27: Напишите программу, которая принимает на вход число и
//  выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// do
// {
    // sum = sum + number % 10;
    // number = number / 10;
// }
// while (number > 0);
// Console.WriteLine($"Сумма чисел:{sum} ");
//-------------------------------------------------------------------------
// Задача 29: Напишите программу, которая задаёт массив из 8 
// элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int[] array = new int[8];
int a = new Random().Next(9);
for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Массив: [{String.Join(",", array)}]");