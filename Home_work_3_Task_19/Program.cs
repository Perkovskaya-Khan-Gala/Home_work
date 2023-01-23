// Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да


int GetFiveDigitNumber(string message)
{
    int resultnumber = 1;
    Console.WriteLine(message);

    while (true)
    {
        bool w = int.TryParse(Console.ReadLine(), out resultnumber);
        if (w && resultnumber >= 10000 && resultnumber <= 99999)
            break;
        else
            Console.WriteLine("Это не число или не пятизначное число. Попробуйте еще раз.");
    }
    return resultnumber;
}

void CheckIfPolyandr(int number)
{
    if (number / 10000 == number % 10)
    {
        if ((number / 1000) % 10 == (number / 10) % 10)
            Console.WriteLine($"{number} -> да");
        else
            Console.WriteLine($"{number} -> нет");
    }
    else
        Console.WriteLine($"{number} -> нет");
}

int number = GetFiveDigitNumber("Введите пятизначное число для проверки на полиандрию");
CheckIfPolyandr(number);