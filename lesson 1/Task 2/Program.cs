// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Привет, эта программа находит наибольшее из трех чисел");

int[] arr = new int[3];

for (int i = 0; i <3; i++)
{
    Console.WriteLine(" Введи число " + (i+1));
    arr[i] =  Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i <3; i++)
{
    Console.Write(" "+arr[i]);
}
Console.WriteLine(" max = "+arr.Max());
