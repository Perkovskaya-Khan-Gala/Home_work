// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int GetNumber(string message)
{
    int result=0;
    while (true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
    {
        break;
    }
    else
    {
        Console.WriteLine("Введено не число. Попробуйте еще раз");
    }
    
    }
    return result;
}

int number_A=GetNumber("Введите число А:");
int number_B=GetNumber("Введите число B:");
int count = 0;
int result =1;
while (count<number_B)
{
    result=result*number_A;
    count++;
}
Console.WriteLine($"{number_A}, {number_B} -> {result}");