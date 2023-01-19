// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

int GetDigitNumber()
{
    Console.WriteLine("Введите число от 1 до 7:");
    string number_s = Console.ReadLine();
    int number = Convert.ToInt32(number_s);
    return number;
}

void CheckWeekEnd(int digit_number)
{
    if (digit_number == 6 || digit_number == 7) Console.WriteLine($"{digit_number} -> да");
    else if (digit_number >= 1 && digit_number <= 5) Console.WriteLine($"{digit_number} -> нет");
    else Console.WriteLine("Попробуйте ввести число от 1 до 7 еще раз");

}



int flag = 1;
string flag_S;

int number = 0;
//int check = 0;
do
{
    number = GetDigitNumber();
    CheckWeekEnd(number);

    Console.WriteLine("Введите 1, чтобы продолжить:");
    flag_S = Console.ReadLine();
    flag = Convert.ToInt32(flag_S);
} while (flag == 1);