// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

int flag=1;
string flag_S;
do{
Console.WriteLine("Введите первое число a:");
string number1_S=Console.ReadLine();
int number1=Convert.ToInt32(number1_S);

Console.WriteLine("Введите второе число b:");
string number2_S=Console.ReadLine();
int number2=Convert.ToInt32(number2_S);

if (number1>number2){Console.WriteLine($"a = {number1}, b = {number2} -> max = {number1}");}
if (number1<number2){Console.WriteLine($"a = {number1}, b = {number2} -> max = {number2}");}
if (number1==number2){Console.WriteLine($"Никакое число ни большее, ни меньшее, попробуйте еще раз");}

Console.WriteLine("Введите 1, чтобы продолжить:");
flag_S=Console.ReadLine();
flag=Convert.ToInt32(flag_S);
}while(flag==1);
