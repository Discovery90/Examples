//Задача 13: Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.WriteLine("Введите любое трёхзначное число: ");
int zavdv = Convert.ToInt32(Console.ReadLine());
string zavdvText = Convert.ToString(zavdv);
if (zavdvText.Length > 2)
{
    Console.WriteLine($"третья цыфра" + zavdvText[2]);
}
else
{
Console.WriteLine("третья цифра отсутствует ");
}


