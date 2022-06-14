//Напишите программу, которая принимает на вход число 
//и проверяет, кратно ли оно одновременно 7 и 23.

Console.Clear();
Console.Write("введи целое положительное число ");

int number = Convert.ToInt32(Console.ReadLine());// 161;                            
int a = 7;
int b = 23;

System.Console.WriteLine(" ");
if (number % a == 0 && number % b == 0) System.Console.WriteLine("Число " + number + " кратно обоим числам");
else if (number % a != 0 && number % b != 0) System.Console.WriteLine("Число " + number + " не кратно ни одному из чисел");
else if (number % a == 0) System.Console.WriteLine("Число " + number + " кратно только числу " + a);
else System.Console.WriteLine("Число " + number + " кратно только числу " + b);
System.Console.WriteLine(" ");