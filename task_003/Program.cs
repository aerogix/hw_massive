//Задайте массив из вещественных чисел с ненулевой дробной частью.
//Найдите разницу между максимальным и минимальным элементов массива.

double[] MakeArray(int min, int max, int size)
{
    double num;
    double num_int;
    double [] array_output = new double [size];
    for (int i = 0; i < size; i++)
    {
        num_int = (new Random().Next(min*100,(max+1)*100));
        num = num_int / 100;
        array_output[i] = num;
    }
    return array_output;
}

void PrintArray(double[] array_input)
{
    for (int i = 0; i < array_input.Length; i++)
    {
        Console.Write($"{array_input[i]} ");
    }
}

double SarchMinElement(double[] array_input)
{
    double min = array_input[1];
    for (int i = 1; i < array_input.Length; i++)
    {
        if ((array_input[i]) < min)
        {
            min = array_input[i];
        }
    }
    return min;
}

double SarchMaxElement(double[] array_input)
{
    double max = array_input[1];
    for (int i = 1; i < array_input.Length; i++)
    {
        if ((array_input[i]) > max)
        {
            max = array_input[i];
        }
    }
    return max;
}
double[] array = MakeArray(1, 100, 10);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(SarchMaxElement(array));
Console.WriteLine(SarchMinElement(array));
double res = SarchMaxElement(array) - SarchMinElement(array);
Console.WriteLine($"Разница: {res}");