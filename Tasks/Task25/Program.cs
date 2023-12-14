// Дано натуральное число в диапазоне от 1 до 100 000. 
// Создайте массив, состоящий из цифр этого числа. 
// Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. 
// Размер массива должен быть равен количеству цифр.

int n = new Random().Next(1, 100001);
Console.WriteLine(n);
int[] array = new int[n.ToString().Length];
for (int i = 0; i < array.Length; i++)
{
    array[i] = n % 10;
    n = n / 10;
}
Array.Reverse(array);

Console.WriteLine(string.Join(" ", array));
