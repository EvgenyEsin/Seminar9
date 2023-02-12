/*
Задача 64: Задайте значение N. Напишите программу,
которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"N = {num} -> '");
Printnumber(num, 1);
Console.Write("\b\b'");

int Printnumber(int start, int end) // метод для создания чисел от N до 1 с помощью рекурсии
{
    Console.Write($"{start}, ");
    if (start == end) return start;
    else return Printnumber(start - 1, end);
}