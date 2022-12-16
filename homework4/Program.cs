/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать метод Math.Pow

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

/* int numberA = ReadInt("Введите число А: ");
int numberB = ReadInt("Введите число B: ");
ToDegree(numberA, numberB);

void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(a + " в степени " + b + " = " + result);
}

// Функция ввода
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
 */

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

*/
/* int number = ReadInt("Введите число: ");

int lens = NumberLen(number);
SumNumbers(number, lens);

int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

void SumNumbers(int n, int lens)
{
    int sum = 0;
    for (int i = 1; i <= lens; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine("Сумма цифр " + sum);
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
  */

/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */

/* int lenArray = ReadInt("Введите длину массива: ");

if (lenArray <= 8 && lenArray > 0 )
{
    int[] randomArray = new int[lenArray];
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = new Random().Next(1, 9);
        Console.Write(randomArray[i] + " ");
    }
}
else
{
    Console.Write("Введен массив больше 8 или 0");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
 */