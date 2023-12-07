// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

int ReadInt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GanerateArray(int size, int leftRange, int rightRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
        tempArray[i] = rand.Next(leftRange, rightRange + 1);
    return tempArray;
}

void PrintArray(int[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

void FindNumber(int[] array, int N)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == N)
        {
            Console.WriteLine("Да");
            return;
        }
    }
    Console.WriteLine("Нет");
}

int size = ReadInt("Укажите размер массива: ");
int[] myArray = GanerateArray(size, -10, 10);
PrintArray(myArray);
int number = ReadInt("Введите искомое число: ");
FindNumber(myArray, number);


// Console.WriteLine("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// Random rand = new Random();
// for(int i = 0; i < size; i++)
//     array[i] = rand.Next(10, 100);
// Console.WriteLine("[" + string.Join(", ", array) + "]");
// Console.WriteLine("Введите искомое число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// for(int i = 0; i < size; i++)
// {
//     if(array[i] == number)
//     {
//         Console.WriteLine("Да");
//         break;
//     }
//     Console.WriteLine("Нет");
// }
