//Задайте произвольный массив. Выведете его элементы, 
//начиная с конца. Использовать рекурсию, не использовать циклы.

int[] CreateRandomArray(int size, int min, int max)
{
    Random rnd = new Random();
    int[]array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max+1);
    }
    return array;
}

void ShowInvertArrayPosMethod(int[] array, int pos)
{
    if (pos >= array.Length)
        return;
    ShowInvertArrayPosMethod(array, pos+1);
    if (pos < array.Length-1)
        Console.Write(", ");
    Console.Write(array[pos]);
}

Console.Clear();
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите минимальное число: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите максимальное число: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
Console.WriteLine($"{String.Join(", ", array)}");  

ShowInvertArrayPosMethod(array, 0);
Console.WriteLine();