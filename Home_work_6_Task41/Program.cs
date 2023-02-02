// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

//вводим через один Enter (разбиваем через Split())

int[] GetArrayOfNumbers(string message)
{
    Console.WriteLine(message);
    string numbers = Console.ReadLine();
    char[] separators = new char[] { ' ', ',' };
    string[] subs = numbers.Split(separators, StringSplitOptions.RemoveEmptyEntries);

    int[] array = new int[subs.Length];
    for (int i = 0; i < subs.Length; i++)
    {
        array[i] = Convert.ToInt32(subs[i]);
    }

    return array;
}

int ReturnPositiveQuantity(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) result++;
    }
    
    return result;
}

int[] array_new = GetArrayOfNumbers("Введите элементы массива через запятую");
int positive_quantity=ReturnPositiveQuantity(array_new);
Console.Write(string.Join(", ",array_new));
Console.Write($" -> {positive_quantity}");
