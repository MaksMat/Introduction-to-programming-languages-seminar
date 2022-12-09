/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

/* 
Console.Write("Введите трехзначное число, ");
bool isParsed = false;
int number = 0;
while (isParsed == false | (number < 99 | number > 999))
{
    isParsed = int.TryParse(Console.ReadLine(), out number);
    if (isParsed == false | (number < 99 | number > 1000))
    {
        Console.WriteLine("Необходимо ввести трехзначное число, повторите ввод!");
    }
    else
    {
        Console.WriteLine("Вторая цифра этого числа, " + number / 10 % 10);
    }
}
 */


/* Задача 13:Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать string[]
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

/* Console.Write("Введите число, ");
bool isParsed = false;
int number = 0;
while (isParsed == false )
{
    isParsed = int.TryParse(Console.ReadLine(), out number);
    if (isParsed == false )
    {
        Console.WriteLine("Повторите ввод Чисел!!!");
    }
}
if (number < 100)
    {
        Console.Write("Третьей цифры нет");
    }
else
{
     while (number > 999)
                {
                    number = number / 10;
                }
     Console.WriteLine("Третья цифра этого числа, " + number % 10);
}
 */

/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.Write("Введите число, ");
bool isParsed = false;
int number = 0;
while (isParsed == false )
{
    isParsed = int.TryParse(Console.ReadLine(), out number);
    if (isParsed == false )
    {
        Console.WriteLine("Повторите ввод Чисел!!!");
    }
}

if (number == 6 || number == 7)
{
   Console.Write("Да");
}
else
{
    Console.Write("Нет");
}