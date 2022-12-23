/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2    1, -7, 567, 89, 223 -> 4 */
/* 
Console.WriteLine("Введите числа через запятую ");
string input = Console.ReadLine();
int result = 0;
int[] numbers = ParseStringToArray(input);
PrintArray(numbers);

int[] ParseStringToArray(string input)
{
    int countNumbers = GetCountNumbersInString(input);
    int[] numbers = new int[countNumbers];
    int indexNumber = 0;
    string substring = string.Empty;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] != ',')
        {
            substring += input[i];
        }
        else
        {
            numbers[indexNumber] = Convert.ToInt32(substring);
            indexNumber++;
            substring = string.Empty;
        }
    }
    if (input[input.Length - 1] != ',')
        numbers[indexNumber] = Convert.ToInt32(substring);
    return numbers;
}

int GetCountNumbersInString(string input)
{
    int count;
    if (input[input.Length - 1] == ',')
        count = 0;
    else
        count = 1;

    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
            count++;
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
        result++;
}
Console.WriteLine();
Console.WriteLine($"Чисел больше 0  = {result}");
 */

/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

/* double b1 = ReadInt("Введите значения b1: ");
double b2 = ReadInt("Введите значения b2: ");
double k1 = ReadInt("Введите значения k1: ");
double k2 = ReadInt("Введите значения k2: ");

double first = (b1 - b2) / (k2 - k1);
double second = (k2 * first) + b2;

Console.WriteLine($"Точка пересечения двух прямых - ({first}:{second})");

// Метод
double ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
} */