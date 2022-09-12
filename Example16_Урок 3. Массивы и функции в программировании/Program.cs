// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли 
// оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите любое число из 5 цифр: ");
// string? number = Console.ReadLine();
// static void CheckingNumber(string? number)
// {
// if (number[0]== number[4] && number[1] == number[3])
// {
// Console.WriteLine($"Палиндром {number} ");
// }
// else Console.WriteLine($"НЕ палиндром {number} ");
// }
// {
// CheckingNumber(number);
// }

//-----------------------------------------------------------------------------------
// Задача 21
// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координату Х1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// 
// Console.WriteLine("Введите координату y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// 
// Console.WriteLine("Введите координату Х2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// 
// Console.WriteLine("Введите координату y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// 
// Console.WriteLine("Введите координату z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// 
// Console.WriteLine("Введите координату z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

// Console.WriteLine($"Расстояние между точками: {Math.Round(d, 3)}");
//----------------------------------------------------------------------------------------------

// Задача 23
// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

//1 способ
// int start = 1;
// int end = 5;
// while (start <= 5)
// {
    // Console.WriteLine(start * start * start);
    // start++;
// }

//2 Способ
int end = Convert.ToInt32(Console.ReadLine());
for (int start = 1; start  <= end ;  start++)
{
    Console.WriteLine(start * start * start );
}
