// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateAndFillArray(int size)
{
    int[] array=new int[size];
    Random rnd=new Random();
    for (int i = 0; i < size; i++)
    {
        array[i]=rnd.Next(100,1000);
    }
    return array;
}

int CountPositiveElements(int[] array)
{
    int count=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0) count++;
    }
    return count;
}
void ShowArrayAndCount(int count, int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
     Console.Write($"{array[array.Length-1]} ] -> {count} ");
}

int[] array_three_didgits=CreateAndFillArray(12);
int count_three_de=CountPositiveElements(array_three_didgits);
ShowArrayAndCount(count_three_de, array_three_didgits);
