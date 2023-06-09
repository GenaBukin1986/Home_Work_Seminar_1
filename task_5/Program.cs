// Задача 7. Выведите последнюю цифру трехзначного числа
// 567 -> 7
// 432 -> 2
Console.Clear();
Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
if (num < 100 || num > 999) Console.Write("Вы ввели не трехзначное число!");
else Console.Write(num % 10);