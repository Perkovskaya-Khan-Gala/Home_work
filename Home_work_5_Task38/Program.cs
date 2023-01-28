//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] CreateAndFillArray(int size)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.NextDouble()*10;
    }
    return array;
}

double FindMinMaxDifference(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    double difference = max - min;
    return difference;
}

void ShowArrayAndMinMaxDifference(double diff, double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]:f2}, ");
    }
    Console.Write($"{array[array.Length - 1]:f2} ] -> {diff:f2} ");
}

double[] array_new = CreateAndFillArray(10);
double difference = FindMinMaxDifference(array_new);
ShowArrayAndMinMaxDifference(difference, array_new);

