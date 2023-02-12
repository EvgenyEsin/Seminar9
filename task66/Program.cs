/*Задача 66: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке
от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Введите число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());
int sum = 0;
Console.Write($"M = {numM}; N = {numN} -> {Printnumber(numM, numN, sum)}");

//метод для подсчета суммы чисел от M до N с помощью рекурсии
int Printnumber(int start, int end, int sum)
{
    if (start > end) // поменяем числа местами, если М больше N
    {
        int temp = start;
        start = end;
        end = temp;
    }
    sum = sum + start; // здесь копится сумма
    if (start == end) return sum;
    else return Printnumber(start + 1, end, sum);// рекурсия
}