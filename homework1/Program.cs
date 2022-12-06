/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */
Console.WriteLine("Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
Console.Write("Введите первое число, ");
int number1Task2 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число, ");
int number2Task2 = int.Parse(Console.ReadLine());

if (number1Task2 != number2Task2)
{
    if (number1Task2 > number2Task2)
{
    Console.Write("Большее число, ");
    Console.Write(number1Task2);
    Console.Write(" .Меньшее число, ");
    Console.Write(number2Task2);
    Console.WriteLine();
}
if (number1Task2 < number2Task2)
{
    Console.Write("Большее число, ");
    Console.Write(number2Task2);
    Console.Write(" .Меньшее число, ");
    Console.Write(number1Task2);
    Console.WriteLine();
}
}
else
{
    Console.Write("Числа равны!");
    Console.WriteLine();
}


/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */
Console.WriteLine("Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
Console.Write("Введите первое число, ");
int number1Task4 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число, ");
int number2Task4 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число, ");
int number3Task4 = int.Parse(Console.ReadLine());

if (number1Task4 > number2Task4)
{
    if (number1Task4 > number3Task4)
    {
        Console.Write(number1Task4);
        Console.WriteLine();
    }
}

if (number2Task4 > number3Task4)
{
    Console.Write(number2Task4);
    Console.WriteLine();
}

else
{
    Console.Write(number3Task4);
    Console.WriteLine();
} 

/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */
Console.WriteLine("Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
Console.Write("Введите число, ");
int number1Task6 = int.Parse(Console.ReadLine());
if ((number1Task6 % 2) == 0)
{
    Console.Write("Чётное");
    Console.WriteLine();
}
else
{
    Console.Write("Не чётное");
    Console.WriteLine();
}


/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */
Console.WriteLine("Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
Console.Write("Введите число, ");
int number1Task8 = int.Parse(Console.ReadLine());
for (int i = 1; i <= number1Task8; i++)
{
    if ((i % 2) == 0)
    {
        Console.Write(i);
        Console.Write(", ");
    }
}