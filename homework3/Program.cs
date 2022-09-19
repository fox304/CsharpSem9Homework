// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.OutputEncoding = System.Text.Encoding.UTF8;

int Recurse(int m,int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Recurse(m - 1, 1);
    return Recurse(m - 1, Recurse(m, n - 1));
}
Console.WriteLine("Вводим значения m = 2 и n = 3");
int m = 2,n = 3;
Console.WriteLine("Функция Аккермана здесь равна {0}",Recurse(m,n));
Console.WriteLine("Вводим значения m = 3 и n = 2");
m = 3;n = 2;
Console.WriteLine("А здесь функция Аккермана равна {0}",Recurse(m,n));
