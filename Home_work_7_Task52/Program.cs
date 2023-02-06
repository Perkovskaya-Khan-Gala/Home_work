// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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

int[,] CreateAndFillArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.Next(0, 11);
        }
    }
    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine(" ");
    }
}

double[] FindColumnAverage(int[,] array)
{
    double[] arrayAverage = new double[array.GetLength(1)];
    double result = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            result = result + array[i, j];
        }
        arrayAverage[j] = Math.Round(result / array.GetLength(0), 2);
        result = 0;
    }
    
    return arrayAverage;
}

int rowQuantity = GetNumber("Введите количество строк массива:");
int columnQuantity = GetNumber("Введите количество столбцов массива:");
int[,] arrayToFill = CreateAndFillArray(rowQuantity, columnQuantity);
ShowArray(arrayToFill);
double[] arrayResult = FindColumnAverage(arrayToFill);
Console.Write("Среднее арифметическое каждого столбца: ");
Console.Write(string.Join("; ", arrayResult));
Console.Write(".");