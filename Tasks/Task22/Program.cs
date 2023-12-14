// Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

int ReadInt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray(int size, int leftRange, int rightRange)
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

int size = ReadInt("Укажите размер массива: ");
int[] array = GenerateArray(size, 1, 100);
PrintArray(array);

int count = 0;
for(int i = 0; i < size; i++)
{
    if(array[i] >= 20 && array[i] <= 90)
       count = count + 1;
}
Console.WriteLine(count);