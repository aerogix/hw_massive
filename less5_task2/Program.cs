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

int [,] CangeRow2dArray(int [,] input_array, int string_no_1, int string_no_2)
{
    if(string_no_1 < 0 | string_no_1 > input_array.GetLength(0)-1 | string_no_2 < 0 | string_no_2 > input_array.GetLength(0)-1)
    {
        Console.WriteLine("Указанные сторки за пределами массива:");
        return input_array;
    }
    else
    {
        int [,] output_array = new int [input_array.GetLength(0),input_array.GetLength(1)];
        for(int j=0; j<input_array.GetLength(1); j++)
        {
            output_array[(string_no_1),j]= input_array[(string_no_2),j];
        }
        for(int j=0; j<input_array.GetLength(1); j++)
        {
            output_array[(string_no_2),j]= input_array[(string_no_1),j];
        }    
        for(int i = 0; i<input_array.GetLength(0); i++)
        {
            if (i != string_no_1 & i != string_no_2)
            { 
                for(int j=0; j<input_array.GetLength(1); j++)
                {
                    output_array[i,j]= input_array[i,j];
                }
            }
        }
        return output_array;
    }
}

int row = 5;
int col = 5;
int min = 1;
int max = 9;

int [,] work_array = Create2dArray(row,col,min,max);
Console.WriteLine("Начальный массив:");
Console.WriteLine();
Show2dArray(work_array);

int no1 = 0;
int no2 = work_array.GetLength(0)-1;

Console.WriteLine();
Console.WriteLine();
int [,] new_array = CangeRow2dArray(work_array,no1,no2);
Console.WriteLine($"Массив, с поменяными строками {no1} и {no2}:");
Console.WriteLine();
Show2dArray(new_array);