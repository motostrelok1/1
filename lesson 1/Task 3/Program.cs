// Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Привет, это программа для определения четности числа");

Console.WriteLine(" Введи число ");
int number =  Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("введенное число четное");
}else {
    Console.WriteLine("введенное число не четное");
}