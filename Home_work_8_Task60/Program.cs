// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


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

int[,,] CreateAndFillArray(int rows, int columns, int levels)
{
    int[,,] array = new int[rows, columns, levels];


    Random rnd = new Random();
    for (int k = 0; k < levels; k++)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j, k] = rnd.Next(10, 99);
            }
        }
    }

    return array;
}

void CheckAndFixRepeatedElements(int[,,] array)
{
    Dictionary<int, int> digitElelment = new Dictionary<int, int>();
    Random rnd = new Random();
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                while(digitElelment.ContainsKey(array[i,j,k])) // пока встречаются повторы - меняем содержимое ячейки
                { 
                    array[i,j,k]=rnd.Next(10, 99); 
                }  
                    digitElelment.Add(array[i,j,k],1);
             
            }
        }
    }
}

void ShowArray(int[,,] array)
{
    Console.WriteLine();
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

int rowsNumber = GetNumber("Введите количество строк мартицы:");
int columnsNumber = GetNumber("Введите количество столбцов мартицы:");
int widthNumber = GetNumber("Введите глубину мартицы:");
int[,,] array3D = CreateAndFillArray(rowsNumber, columnsNumber, widthNumber);
CheckAndFixRepeatedElements(array3D);
ShowArray(array3D);

