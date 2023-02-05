int[,] array = new int[3, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int[] arr = new int[array.GetLength(0)];
for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];
    }
    arr[i] = sum;
}
for (int j = 0; j < arr.Length; j++)
{
    Console.Write($"{arr[j]} ");
}
Console.WriteLine();
int min = 100;
int num = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (min > arr[i])
    {
        min = arr[i];
        num++;
    }
}
Console.WriteLine();
Console.WriteLine(min);
Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов: {num}");