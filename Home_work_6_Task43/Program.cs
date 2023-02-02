// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double GetNumber(string message)
{
    double result=0;
    while(true)
    {
        Console.WriteLine(message);
        if(double.TryParse(Console.ReadLine(), out result)) break;
        else Console.WriteLine("Введено не число. Попробуйте еще раз.");
    }

    return result;
}


(double, double) FindIntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x_result=(b2-b1)/(k1-k2);
    double y_result=k2*x_result+b2;
    
    return (x_result, y_result);
}

double b1_par=GetNumber("Введите параметр b1:");
double k1_par=GetNumber("Введите параметр k1:");
double b2_par=GetNumber("Введите параметр b2:");
double k2_par=GetNumber("Введите параметр k2:");
(double x_coord,double y_coord)=FindIntersectionPoint(b1_par, k1_par, b2_par, k2_par);
Console.WriteLine($"b1= {b1_par}, k1= {k1_par}, b2= {b2_par}, k2= {k2_par} --> ({x_coord:f2}; {y_coord:f2})");

