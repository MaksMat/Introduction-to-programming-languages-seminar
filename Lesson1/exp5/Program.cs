//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//456->6 782->2 918->8

Console.Write("Введите трёхзначное число, ");
int number=int.Parse(Console.ReadLine());

if ((number < 1000) && (number >99))
{
    Console.Write(number % 10);
}
else
{
    Console.WriteLine("Не верное число :)");
}