// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


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

int[,] CreateAndFillArraySpiral(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    int count = 1;
    int layer = 0; 
    if (rows <= columns && rows % 2 == 0) layer = rows / 2; //вычисление количества колец/слоев спирали при матрице с четным количеством строк. Слои вычисляются по наименьшему из значений строка/столбец.
    if (rows <= columns && rows % 2 != 0) layer = rows / 2 + 1; //вычисление количества колец/слоев спирали при матрице с нечетным количеством строк. Когда строк меньше, чем столбцов
    if (rows > columns && columns % 2 == 0) layer = columns / 2; // ...Когда столбцов меньше, чем строк и количество столбцов четное
    if (rows > columns && columns % 2 != 0) layer = columns / 2 + 1; //...Когда столбцов меньше, чем строк и количество столбцов нечетное
//  1  2  3   => количество колец спирали 3/2+1=2
//  10 11 4
//  9  12 5
//  8  7  6

    for (int k = 0; k < layer; k++) // проход по слоям спирали
    {
        for (int j = k; j < columns - k - 1; j++) // проход и заполнение матрицы в направлении слева направо. С первого элемента до предпоследнего включительно в строке слоя:  (1 2 ) 3
        {
            array[k, j] = count;
            count++;
            if(count>rows*columns) break;
        }
        
        for (int i = k; i < rows - k - 1; i++) // проход и заполнение матрицы в направлении сверху вниз. С первого элемента до предпоследнего включительно в столбце слоя
        {
            array[i, columns - k - 1] = count;
            count++;
            if(count>rows*columns) break;
        }
        
        for (int j = columns - k - 1; j > k; j--) // проход и заполнение матрицы в направлении справа налево. С последнего элемента до второго включительно в строке слоя: 8 (7 6)
        {
            array[rows - k - 1, j] = count;
            count++;
            if(count>rows*columns) break;
        }
        
        for (int i = rows - k - 1; i > k; i--) // проход и заполнение матрицы в направлении снизу вверх. С последнего элемента до второго включительно в столбце слоя
        {
            array[i, k] = count;
            count++;
            if(count>rows*columns) break;    
        }
    }
    if(rows==columns&&rows%2!=0) array[layer-1,layer-1]=count;// вручную заполняем центральный элемент при правильной нечетной матрице
    
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


int rowsNumber = GetNumber("Введите количество строк мартицы:");
int columnsNumber = GetNumber("Введите количество столбцов мартицы:");
int[,] arrayNew=CreateAndFillArraySpiral(rowsNumber, columnsNumber);
ShowArray(arrayNew);