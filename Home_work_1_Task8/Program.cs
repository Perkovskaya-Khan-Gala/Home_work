// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

int flag=1;
string flag_S;
string number_S;
int number;
do{
  Console.WriteLine("Введите число N:");
  number_S=Console.ReadLine();
  number=Convert.ToInt32(number_S);
  
  if (number>1) Console.Write($"{number} -> ");
  else Console.WriteLine($"{number} -> четные числа > 1 отсутствуют  ");
  
  for (int i = 2; i <number-1; i+=2)
  {
    Console.Write($" {i}, ");
  }
  if (number%2==0&&number>=2){Console.WriteLine($" {number} ");} //последнее число последовательности без запятой когда N-четное
  else if(number%2!=0&&number>=2) {Console.WriteLine($" {number-1} ");} //последнее число последовательности без запятой когда N-нечетное

  Console.WriteLine("Введите 1, чтобы продолжить:");
  flag_S=Console.ReadLine();
  flag=Convert.ToInt32(flag_S);
}while(flag==1);
