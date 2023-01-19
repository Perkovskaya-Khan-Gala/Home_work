//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

int GetThreeDigitNumber()
{
    Console.WriteLine("Введите трехзначное число");
    string number_s = Console.ReadLine();
    int number = Convert.ToInt32(number_s);
    return number;
}
int ThreeDigitCheck(int input_number)
{
    if ((input_number > 99 && input_number < 1000) || (input_number > -1000 && input_number < -99))
        return input_number;
    else
    {
        Console.WriteLine("Число не трехзначное, попробуйте еще раз");
        return 0;
    }

}
void ShowSecondDigit(int three_digit_number)
{
    int result = (three_digit_number / 10) % 10;
    Console.WriteLine($"{three_digit_number} -> {result}");
}

int flag = 1;
string flag_S;

int number = 0;
int check = 0;
do
{
    do
    {
        number = GetThreeDigitNumber();
        check = ThreeDigitCheck(number);
    } while (check == 0);
    ShowSecondDigit(number);

    Console.WriteLine("Введите 1, чтобы продолжить:");
    flag_S = Console.ReadLine();
    flag = Convert.ToInt32(flag_S);
} while (flag == 1);