//111. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46 782 -> 72 918 -> 98

Random random = new Random();

int randomNumber = random.Next(100,1000);

Console.WriteLine(randomNumber);

int lastDigit = randomNumber % 10;
int firstDigit = randomNumber / 100;
int numberResult = firstDigit * 10 + lastDigit;

Console.WriteLine(numberResult);