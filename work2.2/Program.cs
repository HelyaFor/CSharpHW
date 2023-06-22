/*Напишите программу, которая выводит третью цифру заданного числа или 
сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Пожалуйста, введите число");
int number = int.Parse (Console.ReadLine ());
if (number > 99)
{
    Console.WriteLine("Третья цифра числа: "+ number);
}
else
{
    Console.WriteLine("Третьей цифры нет в указанном числе");
}



/*Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine("третья цифра -> " + anyNumberText[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}*/