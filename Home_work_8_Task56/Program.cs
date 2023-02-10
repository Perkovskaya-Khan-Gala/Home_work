//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result)) break;
        else Console.WriteLine("Введенео не число или число меньшее или равно 0. Попробуйте еще раз.");
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
            array[i, j] = rnd.Next(0, 10);
        }
    }

    return array;
}

void ShowArray(int[,]array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int ReturnRowNumber(int[,] array)
{
    int rowIndex=0;
    int rowSum=0;
    int minSum=1000;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        rowSum=0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowSum=rowSum+array[i,j];
        }
        if(rowSum<minSum)
        {
            minSum=rowSum;
            rowIndex=i;
        }
    }

    return rowIndex;
}

int rowNumber=GetNumber("Введите количество строк:");
int columnNumber=GetNumber("Введите количество столбцов:");
int[,] arrayNew=CreateAndFillArray(rowNumber, columnNumber);
ShowArray(arrayNew);
int rowMinSumm=ReturnRowNumber(arrayNew);
Console.WriteLine($"Номер строки с минимальной суммой: {rowMinSumm}");
