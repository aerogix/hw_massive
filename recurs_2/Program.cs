//Напишите программу вычисления функции Аккермана с 
//помощью рекурсии. Даны два неотрицательных числа m и n.

int EnterNaturalNum(string message)
{
    int res;
    
    while (true)
    {
        Console.Write("Enter param {0}: ", message);
        if (int.TryParse(Console.ReadLine(), out res))
            if (res >= 0)
                break;
        Console.WriteLine("Число должно быть больше или равно нулю");
    }
    return res;
}

int Akkerman(int m, int n)
{
    if (m == 0) 
        return n + 1;                                   
    else if (n == 0) 
        return Akkerman(m - 1, 1);                      
    else 
        return Akkerman(m - 1, Akkerman(m, n - 1));     
}

Console.Clear();
Console.WriteLine("Функция аккермана f(m, n)");
int m = EnterNaturalNum("m");
int n = EnterNaturalNum("n");
Console.WriteLine($"Аккерман({m}, {n}) = {Akkerman(m, n)}");