// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число, обозначающее день недели");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 7 || num < 1) Console.WriteLine("Такого дня недели не существует");
else
{
    if (num == 6 || num == 7) 
    Console.WriteLine("да, это выходной :)");
    else 
    Console.WriteLine("нет, это не выходной");
}