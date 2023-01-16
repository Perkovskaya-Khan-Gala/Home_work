// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

int flag=1;
string flag_S;
string number_S;
int number;
int result;
do{
Console.WriteLine("Введите число:");
number_S=Console.ReadLine();
number=Convert.ToInt32(number_S);
result=number%2;

if (result==0){Console.WriteLine($"{number} -> да");}
else {Console.WriteLine($"{number} -> нет");}

Console.WriteLine("Введите 1, чтобы продолжить:");
flag_S=Console.ReadLine();
flag=Convert.ToInt32(flag_S);
}while(flag==1);