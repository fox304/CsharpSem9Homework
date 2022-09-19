// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных чисел в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.OutputEncoding = System.Text.Encoding.UTF8;
int Recurse(int m, int n)
{
    if (m == n) return n;
    return Recurse(m, n - 1) + n;
}

Console.WriteLine("Введите значения M и N ");
Console.WriteLine("Введите значение M ");
int n = 0,m = 0;
while (true)
{
    Console.WriteLine("Значение M  должно быть больше нуля ");
    m = Convert.ToInt32(Console.ReadLine());
    if (m > 0) break;
}

Console.WriteLine("Введите значение N ");
while (true)
{
    Console.WriteLine("Значение N должно быть больше M ");
    n = Convert.ToInt32(Console.ReadLine());
    if (n > m) break;
}

Console.WriteLine($"Сумма натуральных чисел в промежутке от M={m} до N={n} будет такая {Recurse(m, n)} ");

