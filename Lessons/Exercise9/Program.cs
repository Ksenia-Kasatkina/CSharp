int N = 10;
int[] array = { 5, 8, 12, 54, 74, 65, 2, 11, 25, 55 };
int i = 0;
int max = array[0];

while (i < N)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i = i + 1;
}
Console.WriteLine(max);