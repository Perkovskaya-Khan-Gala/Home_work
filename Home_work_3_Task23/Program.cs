// Задача 23

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

int GetNNumber(string message)
{
    int result = 0;
    Console.WriteLine(message);
    while (true)
    {
        bool y_or_n = int.TryParse(Console.ReadLine(), out result);
        if (y_or_n&&result>=0)
            break;
        else
            Console.WriteLine("Введено не число или отрицательное число. Попробуйте еще раз");
    }
    return result;
}

void ShowCubeTable(int number)
{
    
    int i=1;
    Console.Write($"{number} -> ");
    while(i<number)
    {
        //double cube=Math.Pow(i,3);
        Console.Write($"{Math.Pow(i,3)}, ");
        i++;
    }
    Console.Write($"{Math.Pow(number,3)}");
}

int number = GetNNumber("Введите положительное число N:");
ShowCubeTable(number);