// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

int [,] Create2dArray(int row, int col, int min, int max)
{
    int [,] array = new int [row,col];
    for (int i =0; i<row; i++)
    {
        for(int j = 0; j<col;j++)
        {
            array[i,j] = new Random().Next(min, max+1);
        }
    }
    return array;
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}

int NumMinRowSum2dArray(int [,] input_array)
{
    int num_min_row = 0;
    int sum_min = 0;
    for(int j=0; j<input_array.GetLength(1); j++)
        {
            sum_min= sum_min + input_array[0,j];
        }
    for(int i = 1; i<input_array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j=0; j<input_array.GetLength(1); j++)
        {
            sum = sum + input_array[i,j];
        }
        if (sum < sum_min)
        {
            sum_min = sum;
            num_min_row = i;
        }
    }
    return num_min_row;
}




int row = 5;
int col = 5;
int min = 1;
int max = 9;

int [,] work_array = Create2dArray(row,col,min,max);
Console.WriteLine("Массив:");
Console.WriteLine();
Show2dArray(work_array);

Console.WriteLine($"Номер строки с минимльной суммой значений: {NumMinRowSum2dArray(work_array)}");
