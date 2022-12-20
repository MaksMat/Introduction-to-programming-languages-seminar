// Задача 31: Задайте массив из 12 элементов, заполненный случайными 
// числами из промежутка [-9, 9]. Найдите сумму отрицательных и 
// положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.



//Вариант1
int[] array = CreateRandomArray(12, -9, 9); // создаем массив используя метод
PrintArray(array); //выводим в консоль массив с помощью созданного метода 
//int sumPositive = GetSumPositive(array);
//Console.WriteLine(sumPositive);

//int sumNegative = GetSumNegative(array);
//Console.WriteLine(sumNegative);

int[] CreateRandomArray(int size, int minValue, int maxValue)
{

    Random random = new Random();
    int[] array = new int[size];
    for (var i = 0; i < size; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    string str = string.Join(",",array);
    Console.WriteLine($"[{str}]");
    //Console.WriteLine(string.Join(", ", array));

}

