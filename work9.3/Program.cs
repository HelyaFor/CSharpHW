/*Напишите программу вычисления функции Аккермана с помощью 
рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.WriteLine("Пожалуйста, введите положительное число (M): ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Пожалуйста, введите положительное число (N): ");
int n = Convert.ToInt32(Console.ReadLine());
int res = 0;

int Akkerman (int m, int n)
{
    if (m == 0)
    {
        return res = n + 1;
    }
    else 
        if (m > 0 && n == 0) 
        {
            return res = Akkerman (m - 1,1);
        }
        else
        {
            return res = Akkerman (m - 1, Akkerman(m, n -1));
        }
}
Akkerman(m, n);
Console.WriteLine("Ответ: " + res);
