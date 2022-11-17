// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0) num = -num;

while (num / 100 > 9) num = num / 10;

if (num / 100 > 0)
    {
    int thirdCifra = num % 10;
    Console.WriteLine($"третья цифра: {thirdCifra}");
    }
else
    Console.WriteLine("третьей цифры нет");
