// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

void ShowArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] ReturnResultMatrix(int[,] arrayOne, int[,] arrayTwo)
{

    int[,] arrayResult = new int[arrayOne.GetLength(0), arrayTwo.GetLength(1)];
    for (int i = 0; i < arrayOne.GetLength(0); i++)
    {
        for (int j = 0; j < arrayTwo.GetLength(1); j++)
        {
            for (int k = 0; k < arrayOne.GetLength(1); k++)
            {
                arrayResult[i, j] += arrayOne[i, k] * arrayTwo[k, j];
            }
        }
    }

    return arrayResult;
}

bool CheckIfCanMultiple(int[,] arrayOne, int[,] arrayTwo)
{
    if (arrayOne.GetLength(1) == arrayTwo.GetLength(0)) return true;
    else return false;
}

int rowNumberFirst = GetNumber("Введите количество строк 1 матрицы:");
int columnNumberFirst = GetNumber("Введите количество столбцов 1 матрицы:");
int rowNumberSecond = GetNumber("Введите количество строк 2 матрицы:");
int columnNumberSecond = GetNumber("Введите количество столбцов 2 матрицы:");
int[,] arrayNewFirst = CreateAndFillArray(rowNumberFirst, columnNumberFirst);
int[,] arrayNewSecond = CreateAndFillArray(rowNumberSecond, columnNumberSecond);
ShowArray(arrayNewFirst);
ShowArray(arrayNewSecond);
if (CheckIfCanMultiple(arrayNewFirst, arrayNewSecond)) {
    int[,] arrayMiltipliedMatrexes=ReturnResultMatrix(arrayNewFirst, arrayNewSecond);
    Console.WriteLine("Результат перемножения:");
    ShowArray(arrayMiltipliedMatrexes);
}
else Console.WriteLine("Перемножить данные матрицы невозможно.");
