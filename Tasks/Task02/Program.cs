// Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.

Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.Write("max - ");
    Console.WriteLine(a);
    Console.Write("min - ");
    Console.WriteLine(b);
}
else
{
    Console.Write("max - ");
    Console.WriteLine(b);
    Console.Write("min - ");
    Console.WriteLine(a);
}