// // Задача 34: Задайте массив заполненный случайными 
// // положительными трёхзначными числами. Напишите программу, 
// // которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2

// int number = Convert.ToInt32(Console.ReadLine());

// int[] array = GetArray(number);

// int[] GetArray(int size)
// {
//     int[] arr = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(234, 898);
//         Console.Write(arr[i] + " ");
//     }
//     return arr;
// }

// int Get2Array(int[] TomasShelby)
// {

//     int count = 0;
//     for (int i = 0; i < TomasShelby.Length; i++)
//     {
//         System.Console.WriteLine(TomasShelby[i]);
//         if (TomasShelby[i] % 2 == 0)
//         {
//             count += 1;
//         }
//     }
//     return count;
// }
// Console.WriteLine($" чётных чисел : {Get2Array(array)}");
//--------------------------------------------------------------------------------------------------

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6]-> 0

// int number = Convert.ToInt32(Console.ReadLine());
// int[] array = GetArray(number);
// int[] GetArray(int size)
// {
// int[] arr = new int[size];
// for (int i = 0; i < size; i++)
// {
// arr[i] = new Random().Next(10, 100);
// Console.Write(arr[i] + " ");
// }
// return arr;
// }
// int count = Get2Array(array);
// int Get2Array(int[] array)
// {
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
// if (i % 2 != 0)
// {
// count = count + array[i];
// }
// }
// return count;
// }
// Console.WriteLine($"суммa элементов, стоящих на нечётных позициях. = {count}");
//---------------------------------------------------------------------------------------------

//Задача 38: Задайте массив вещественных чисел. Найдите 
//разницу между максимальным и минимальным элементов массива.

Console.Write("Задайте длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] massive = new int[num];

FillArray(massive);
WriteArray(massive);

int max = 0;
int min = 100;
for (int i = 0; i < massive.Length; i++)
{
    if (massive[i] > max)
    {
        max = massive[i];
    }

    if (massive[i] < min)
    {
        min = massive[i];
    }
}
int difference = max - min;

Console.WriteLine($"Максимальное число в данном массиве: {max}");
Console.WriteLine($"Минимальное число в данном массиве: {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением: {difference}");

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 101);
    }
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}







