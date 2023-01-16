// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

int flag=1;
string flag_S;
string number1_S;
int number1;
string number2_S;
int number2;
string number3_S;
int number3;
int max=0;;
do{
Console.WriteLine("Введите первое число:");
number1_S=Console.ReadLine();
number1=Convert.ToInt32(number1_S);

Console.WriteLine("Введите второе число:");
number2_S=Console.ReadLine();
number2=Convert.ToInt32(number2_S);

Console.WriteLine("Введите третье число:");
number3_S=Console.ReadLine();
number3=Convert.ToInt32(number3_S);

if (number1>=number2&&number1>=number3){max=number1;}
if (number2>=number1&&number2>=number3){max=number2;}
if (number3>=number2&&number3>=number1){max=number3;}

Console.WriteLine($"{number1}, {number2}, {number3} -> {max}");

Console.WriteLine("Введите 1, чтобы продолжить:");
flag_S=Console.ReadLine();
flag=Convert.ToInt32(flag_S);
}while(flag==1);





