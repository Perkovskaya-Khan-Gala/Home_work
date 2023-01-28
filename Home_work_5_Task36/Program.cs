// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] CreateAndFillArray(int size)
{
    int[] array=new int[size];
    Random rnd=new Random();
    for (int i = 0; i < size; i++)
    {
        array[i]=rnd.Next(-100,100);
    }
    return array;
}

int FindSumm(int[] array)
{
    int sum=0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum+=array[i];
    }
    return sum;
}

void ShowArrayAndSum(int sum, int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
     Console.Write($"{array[array.Length-1]} ] -> {sum} ");
}

int [] array_new=CreateAndFillArray(7);
int sum_of_elem=FindSumm(array_new);
ShowArrayAndSum(sum_of_elem, array_new);