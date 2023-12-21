//Задайте значения M и N. Напишите программу, которая выведет все натуральные 
//числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

int EnterNaturalNum(string message)
{
    int res;
    
    while (true)
    {
        Console.Write("Введите {0} число: ", message);
        if (int.TryParse(Console.ReadLine(), out res))
            if (res > 0)
                break;
        Console.WriteLine("Число должно быть больше нуля");
    }
    return res;
}

void ShowNumbersFromRange(int start, int end)
{
    if (end < start)
        return;
    ShowNumbersFromRange(start, end-1);    
    if (start != end)
        Console.Write(", ");
    Console.Write(end);                     
}


Console.Clear();
int startRange = EnterNaturalNum("начальное");
int endRange = EnterNaturalNum("конечное");
if (startRange > endRange) 
    (startRange, endRange) = (endRange, startRange);

ShowNumbersFromRange(startRange, endRange);