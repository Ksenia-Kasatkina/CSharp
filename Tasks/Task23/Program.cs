// // Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет количество чётных чисел в массиве.

int ReadInt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
// (Тут была функция для заполнения массива пользователем. Не смогла разобраться, пишет "Не удается неявно преобразовать тип "int[]" в "int")
// int InputNumber(int size)
// {
//     int[] tempArray = new int[size];
//     for (int i = 0; i < size; i++)
//         tempArray[i] = ReadInt($"Введите {i + 1}-й элемент массива: ");
//     return tempArray;
// }

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

int EvenNumber(int [] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count = count + 1;
        }
        i++;
    }
    return count;
}

int size = ReadInt("Задайте размер массива: ");
int[] array = new int[size];
for (int i = 0; i < size; i++)
    array[i] = ReadInt($"Введите {i + 1}-й элемент массива: ");
PrintArray(array);
Console.WriteLine(EvenNumber(array));
