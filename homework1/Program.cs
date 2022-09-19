// Задача 64: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
Console.OutputEncoding = System.Text.Encoding.UTF8;
void Recurse(int m, int n)
{
    if (m == n+1) return;
    Recurse(m, n - 1);
    Console.Write($"{n} ");
}

Console.WriteLine("Введите значения M и N ");
Console.WriteLine("Введите значение M ");
int n = 0,m = 0;
while (true)
{
    Console.WriteLine("Значение M  должно быть больше ноля ");
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

Console.WriteLine($"Натуральные числа,включая M и N в промежутке от M={m} до N={n} будут такими");
Recurse(m, n);



