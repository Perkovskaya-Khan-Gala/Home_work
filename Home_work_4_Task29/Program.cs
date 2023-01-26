// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int GetNumber(string message) //для задания элементов массива
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result)) break;
        else Console.WriteLine("Введено не число. Попробуйте еще раз");
    }
    return result;
}
int GetPositiveNumber(string message) //для задания размера массива
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0) break;
        else Console.WriteLine("Введено не число или число меньшее или равно нулю . Попробуйте еще раз");
    }
    return result;
}
int[] GetSizeAndFillArray(int size) //для заполнения массива с консоли
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = GetNumber($"Введите {i} элемент массива:");
    }
    return array;
}
void ShowArray(int[] array) //для вывода маасива на экран
{
    Console.Write($"[ ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]} ]");
}


int array_size = GetPositiveNumber("Введите размер массива");
int[] array_to_fill = GetSizeAndFillArray(array_size);
ShowArray(array_to_fill);
