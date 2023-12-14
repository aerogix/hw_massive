﻿// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
// , и возвращает значение этого элемента или же указание, что такого элемента нет.

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

void Num2dArray(int [,] input_array, int [] no_array)
{
    if (no_array[0] <0 | no_array[0] > input_array.GetLength(0) | no_array[1] <0 | no_array[1] > input_array.GetLength(1))
    {
        Console.Write("Указанные позиции за границами массива.");
    }
    else
    {
        Console.Write($"Значение элемента массива с указанными позициями: {input_array[no_array[0], no_array[1]]}");
    }
}




int row = 10;
int col = 10;
int min = 1;
int max = 9;
int [] array_input = new int[2];


int [,] work_array = Create2dArray(row,col,min,max);
Show2dArray(work_array);
Console.WriteLine();

Console.Write("Введите номер строки: ");
array_input[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ноамер столбца: ");
array_input[1] = Convert.ToInt32(Console.ReadLine());
Num2dArray(work_array, array_input);
