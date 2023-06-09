// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Clear();
Console.Write("Введите чилсло a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чилсло b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чилсло c: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c) Console.Write($"max = {a}");
if (c > b && a < c) Console.Write($"max = {c}");
if (b > a && b > c) Console.Write($"max = {b}");