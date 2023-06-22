/*Напишите программу, которая принимает на вход пятизначное число и 
проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Пожалуйста, введите пятизначное число: ");
string number = Console.ReadLine();
int num = number.Length;

if (num == 5)
{
    if (number[0] == number[4] && number [1] == number[3])
    {
        Console.WriteLine("Ваше число - палиндром");
    }

    else
    {
        Console.WriteLine("Ваше число НЕ является палиндромом");
    }
}
else
{
    Console.WriteLine("Введено не пятизначное число. Попробуйте снова.");
}