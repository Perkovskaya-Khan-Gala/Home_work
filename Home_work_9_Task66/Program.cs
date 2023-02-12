// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0) break;
        else Console.WriteLine("Введено не число или число меньшее или равное нулю. Попробуйте еще раз");
    }

    return result;
}

int GetNumberMax(string message, int minNumber)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > minNumber) break;
        else Console.WriteLine("Введено не число или число меньшее или равно, чем первое число N. Попробуйте еще раз");
    }

    return result;
}

int FindSumFromMinToMax(int minNumber, int maxNumber)
{
    if (minNumber<=maxNumber) return minNumber+FindSumFromMinToMax(minNumber+1, maxNumber);
    else return 0;
}

int numberM=GetNumber("Введите натуральное положительное число M:");
int numberN=GetNumberMax("Введите натуральное положительное число N, большее, чем M", numberM);
int resultSum=FindSumFromMinToMax(numberM, numberN);
Console.Write($"M = {numberM}; N = {numberN} -> {resultSum}");