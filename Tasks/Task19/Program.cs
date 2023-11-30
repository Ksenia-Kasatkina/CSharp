// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

int ReadInt(string text)
{
Console.Write(text);
return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray(int size, int leftRange, int rightRange)
{
int[] tempArray = new int[size];
Random rand = new Random();

for (int i = 0; i < size; i++)
{
tempArray[i] = rand.Next(leftRange, rightRange + 1);
}

return tempArray;
}

void PrintArray(int[] array)
{
System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}
void FindNumber(int[] array, int N)
{
for(int i = 0; i < array.Length; i++)
{
if(array[i] == N)
{
System.Console.WriteLine("Да");
return;
}
}

System.Console.WriteLine("Нет");
}

// Основной код

int size = ReadInt("Введите размер массива: ");
int[] myArray = GenerateArray(size, -10, 10);
PrintArray(myArray);

int number = ReadInt("Введите искомое число: ");
FindNumber(myArray, number);