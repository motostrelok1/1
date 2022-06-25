// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
System.Console.WriteLine();

// вводим число
Console.Write(" введите целое число ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num; //сохраняем для вывода в консоль

// разбиваем число на разряды и складываем в сумматор
int sum = 0;
while (num>0){
    sum = sum + num%10; 
    num=(num-(num%10))/10;}
Console.Write("сумма цифр числа  " + num1 + " = " + sum);
