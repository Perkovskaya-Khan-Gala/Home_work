// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result >= 0) break;
        else Console.WriteLine("Введено не число или число меньшее нуля. Попробуйте еще раз");
    }

    return result;
}

int FindAkkermanFunctionSign(int numberM, int numberN)
{
    if (numberM>0&&numberN>0) return FindAkkermanFunctionSign(numberM-1, FindAkkermanFunctionSign(numberM, numberN-1));
    if (numberM>0&&numberN==0) return FindAkkermanFunctionSign(numberM-1, 1);
    if (numberM==0) return numberN+1;
    else return 0;
}

int numberAkkermanM=GetNumber("Введите положительное целое число M:");
int numberAkkermanN=GetNumber("Введите положительное целое число N:");
int numberAkkermanResult=FindAkkermanFunctionSign(numberAkkermanM, numberAkkermanN);
Console.Write($"m = {numberAkkermanM}, n = {numberAkkermanN} -> A(m,n) = {numberAkkermanResult}");