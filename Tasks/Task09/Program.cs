// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100); // [10, 100)

int leftDigit = number / 10;
int rightDigit = number % 10;

if (leftDigit > rightDigit)
{
    Console.Write($"{number} -> {leftDigit}");
}
else
{
    Console.Write($"{number} -> {rightDigit}");
}
Console.WriteLine();


