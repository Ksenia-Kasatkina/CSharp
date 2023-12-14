// Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементами массива.

int ReadInt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

double[] GenerateArray(int size, int leftRange, int rightRange)
{
    double[] tempArray = new double[size];
    Random rand = new Random();
    for (int i = 0; i < tempArray.Length; i++)
        tempArray[i] = Math.Round(rand.Next(0, 10) + rand.NextDouble(), 2);
    return tempArray;
}

void PrintArray(double[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

void MinMaxNumber(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
Console.WriteLine($"Минимальный элемент: {min}");
Console.WriteLine($"Максимальный элемент: {max}");
}

int size = ReadInt("Задайте размер массива: ");
double[] array = GenerateArray(size, 0, 10);
PrintArray(array);
MinMaxNumber(array);