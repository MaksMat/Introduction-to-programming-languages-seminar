﻿//Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда 5 -> Пятница

Console.Write("Введите число от 1-7, ");
int number = int.Parse(Console.ReadLine());
if ((number < 8) && (number >0))
    {
        if (number == 1)
        {
            Console.WriteLine("Понедельник");
        }
        if (number == 2)
        {
            Console.WriteLine("Вторник");
        }
        if (number == 3)
        {
            Console.WriteLine("Среда");
        }
        if (number == 4)
        {
            Console.WriteLine("Четверг");
        }
        if (number == 5)
        {
            Console.WriteLine("Пятница");
        }
        if (number == 6)
        {
            Console.WriteLine("Суббота");
        }
        if (number == 7)
        {
            Console.WriteLine("Воскресенье");
        }
    }
else
{
    Console.WriteLine("Не верное число :)");
}