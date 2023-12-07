// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

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
    Console.WriteLine("[" + string.Join(" ", array) + "]");

}

int size = ReadInt("Укажите размер массива: ");
int[] myArray = GenerateArray(size, 0, 10);
PrintArray(myArray);
int[] newArray = new int[size / 2];
for (int i = 0; i < myArray.Length / 2; i++)
    newArray[i] = myArray[i] * myArray[myArray.Length - 1 - i];
PrintArray(newArray);