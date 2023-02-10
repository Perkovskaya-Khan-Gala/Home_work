//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void RegularizeRowsBubbleSort(int[,] array)
{
    int temp = 0;
    bool flag = true;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        flag=true;
        while (flag)
        {
            flag = false;
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[i, j] > array[i, j + 1])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                    flag = true;
                }

            }
        }
    }
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

int rowNumber=GetNumber("Введите количество строк:");
int columnNumber=GetNumber("Введите количество столбцов:");
int[,] arrayNew=CreateAndFillArray(rowNumber, columnNumber);
ShowArray(arrayNew);
RegularizeRowsBubbleSort(arrayNew);
ShowArray(arrayNew);

