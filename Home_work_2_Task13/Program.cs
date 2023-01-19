// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6

int GetDigitNumber()
{
    Console.WriteLine("Введите положительное число:");
    string number_s = Console.ReadLine();
    int number = Convert.ToInt32(number_s);
    return number;
}

void ShowThirdDigit(int digit_number)
{
    int clone_number = digit_number;
    int result = digit_number / 100;
    if (result == 0) Console.WriteLine($"{digit_number} -> третьей цифры нет");
    if (result > 0)
    {
        while (clone_number >= 1000)
        {
            clone_number = clone_number / 10;
        }
        result = clone_number % 10;
        Console.WriteLine($"{digit_number} -> {result}");
    }
}



int flag = 1;
string flag_S;

int number = 0;
do
{
    number = GetDigitNumber();
    ShowThirdDigit(number);

    Console.WriteLine("Введите 1, чтобы продолжить:");
    flag_S = Console.ReadLine();
    flag = Convert.ToInt32(flag_S);
} while (flag == 1);