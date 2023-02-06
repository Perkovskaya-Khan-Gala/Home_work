// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0) break;
        else Console.WriteLine("Введено не число или же число меньшее или равное нулю. Попробуйте еще раз.");
    }
    
    return result;
}

double[,] CreateAndFillArray(int rows, int columns)
{
    double[,] array = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.NextDouble() * rnd.Next(-10, 10);
        }
    }
    
    return array;
}
void ShowArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:f1} ");
        }
        Console.WriteLine(" ");
    }
}

int mRows = GetNumber("Введите количество строк m:");
int nColumns = GetNumber("Введите количество столбцов n:");
double[,] newArray = CreateAndFillArray(mRows, nColumns);
Console.WriteLine($"m = {mRows}, n = {nColumns}");
ShowArray(newArray);
