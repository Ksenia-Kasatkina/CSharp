// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]

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
void ChangeSign(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = -array[i];
}

int size = ReadInt("Задайте размер массива: ");
int[] myArray = GenerateArray(size, -10, 10);
PrintArray(myArray);
ChangeSign(myArray);
PrintArray(myArray);