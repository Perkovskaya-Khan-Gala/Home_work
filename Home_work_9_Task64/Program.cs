// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

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

string ShowNumbersMaxToMin(int start, int finish)
{
    if (finish > start) return $"{finish}, " + ShowNumbersMaxToMin(start, finish - 1);
    if (finish == start) return $"{finish}";
    else return string.Empty;
}

int numberN = GetNumber("Введите число N:");
Console.Write($"N = {numberN} -> ");
Console.Write("'{0}'",ShowNumbersMaxToMin(1, numberN));