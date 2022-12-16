//12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4 16, 4 -> кратно

int ReadNumber(string text)
{
    Console.WriteLine(text);
    bool isParsed = false;
    int number;
    for (int i = 0; i < 5; i++)
    {
        if (isParsed == false)
        {
            isParsed = int.TryParse(Console.ReadLine(), out number);
            if (isParsed == false)
            {
                Console.WriteLine("Повторите ввод Чисел!!!");
            }

        }
    }
}


int firstNumber = ReadNumber("Enter first number");
int secondNumber = ReadNumber("Enter second number");
Console.WriteLine("first number: " + firstNumber);
Console.WriteLine("second number: " + secondNumber);