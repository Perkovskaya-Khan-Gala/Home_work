//Задача 21

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53


int GetDigitNumber(string message)
{
    Console.WriteLine(message);
    int result = 0;
    while (true)
    {
        bool y_n = int.TryParse(Console.ReadLine(), out result);
        if (y_n)
            break;
        else
            Console.WriteLine("Введена не цифра. Попробуйте еще раз");
    }
    return result;
}
double FindDistance(int x1, int x2, int y1, int y2, int z1, int z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}

int x1_coord = GetDigitNumber("Введите координату x1 первой точки");
int y1_coord = GetDigitNumber("Введите координату y1 первой точки");
int z1_coord = GetDigitNumber("Введите координату z1 первой точки");
int x2_coord = GetDigitNumber("Введите координату x2 второй точки");
int y2_coord = GetDigitNumber("Введите координату y2 второй точки");
int z2_coord = GetDigitNumber("Введите координату z2 второй точки");

double distance_3D = FindDistance(x1_coord, x2_coord, y1_coord, y2_coord, z1_coord, z2_coord);
Console.WriteLine($"Расстояние между двумя точками в 3D пространстве: A({x1_coord},{y1_coord},{z1_coord}); B({x2_coord},{y2_coord},{z2_coord}) -> {distance_3D:f2}");