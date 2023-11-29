//Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите
//количество элементов массива, значения которых лежат в отрезке [20,90].

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

int SearchElement(int min, int max, int[] array_input)
{
    int res = 0;
    for (int i = 0; i < array_input.Length; i++)
    {
        if ((array_input[i] < max) & (array_input[i] > min))
        {
            res++;
        }
    }
    return res;
}

int[] array = CreateArray(1, 100, 10);

PrintArray(array);

Console.WriteLine();

int res = SearchElement(20, 90, array);

Console.WriteLine();

Console.WriteLine($"Количество элементов {res}");
