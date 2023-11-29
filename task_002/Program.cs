//Задайте массив на 10 целых чисел. Напишите программу, 
//которая определяет количество чётных чисел в массиве.

int [] CreateArray(int min, int max, int size){

    int num;
    int [] array_output = new int [size];
    for(int i = 0; i<size; i++){
        num = new Random().Next(min, max+1);
        array_output[i] = num;
    }
    return array_output; 
}
void PrintArray(int[] array_input)
{
    for (int i = 0; i < array_input.Length; i++)
    {
        Console.Write($"{array_input[i]} ");
    }
}
int Amount(int min, int max, int[] array_input)
{
    int res = 0;
    for (int i = 0; i < array_input.Length; i++)
    {
        if (array_input[i] % 2 == 0){
                res++;
            }
    }
    return res;
}
int[] array = CreateArray(1, 100, 10);
PrintArray(array);
Console.WriteLine();
int res = Amount(1, 100, array);
Console.WriteLine($"Количество четных чисел {res}");