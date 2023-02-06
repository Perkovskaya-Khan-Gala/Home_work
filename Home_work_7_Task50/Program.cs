// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// пользователь вводит индексы 10, 10 - такого элемента нет.
// пользователь вводите индексы 0, 2 - выводим элеменет 7

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
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine(" ");
    }
}

(int, int) GetPosition(string message)
{
string inputIndexies=string.Empty;
string[] subs=new string[2];
 char[] separators = new char[] { ' ', ',' };
    while (true)
    {
        Console.WriteLine(message);
        inputIndexies = Console.ReadLine();     
        subs = inputIndexies.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        if (subs.Length == 2) break;
        
        else Console.WriteLine("Введено неверное количество индексов. Попробуйте еще раз");
    }

    int rows = Convert.ToInt32(subs[0]);
    int columns = Convert.ToInt32(subs[1]);
    
    return (rows, columns);5
}

void CheckIfPositionExist(int[,] array, int row, int column)
{
    if (row < array.GetLength(0) && column < array.GetLength(1)) Console.WriteLine(array[row, column]);
    else Console.WriteLine($"{row}, {column}:такого элемента  в массиве не существует");
}

int rowQuantity = GetNumber("Введите количество строк массива:");
int columnQuantity = GetNumber("Введите количество столбцов массива:");
int[,] arrayToFill = CreateAndFillArray(rowQuantity, columnQuantity);
ShowArray(arrayToFill);
while (true)
{
(int rowPosition, int columnPosition) = GetPosition("Введите через пробел/запятую позицию элемента массива для его вывода на экран:");
CheckIfPositionExist(arrayToFill, rowPosition, columnPosition);
}
