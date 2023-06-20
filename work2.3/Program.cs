/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Пожалуйста, введите день недели: ");
int day = int.Parse(Console.ReadLine());
if (day <= 5)
{
    Console.WriteLine("Будний день");
}
else if (day >= 6 && day <= 7)
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Такого дня нет");
}