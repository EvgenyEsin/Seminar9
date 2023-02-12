/*Задача 68: Напишите программу вычисления функции Аккермана
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.WriteLine("Введите число m: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int numN = Convert.ToInt32(Console.ReadLine());
Console.Write($"m = {numM}; n = {numN} -> A(m,n) = ");
Console.Write(Ackkerman(numM, numN));

// метод вычисления функции Аккекмана с помощью рекурсии
int Ackkerman(int m, int n)
{
    // способ № 1.
    if (m == 0) return n + 1;
    else if (n == 0 && m > 0) return Ackkerman(m - 1, 1);
    else return Ackkerman(m - 1, Ackkerman(m, n - 1));

    /* способ № 2.
    while (m!=0)
    {
        if (n == 0) return Ackkerman (m-1, 1);
        else return Ackkerman(m-1, Ackkerman(m, n-1));
    }
    return n + 1;
    */
}