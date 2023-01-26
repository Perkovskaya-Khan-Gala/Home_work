// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int GetNumber(string message)
{
    int result=0;
    while(true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result)) break;
        else Console.WriteLine("Введено не число. Попробуйте еще раз");
    }
    return result;
}

int FindSummOfDigits(int number)
{
    int result = 0;
    while (number>0)
    {
        result=result+number%10;
        number=number/10;
    }
    return result;
}

int input_number=GetNumber("Введите число:");
int sum_result= FindSummOfDigits(input_number);
Console.WriteLine($"{input_number} -> {sum_result}");