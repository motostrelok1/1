// Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Привет, это программа сравнения двух целых, положительных чисел");
// ввод с клавиатуры 2х чисел
Console.WriteLine(" Введи первое целое число ");       
int firstNumber =  Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Введи второе целое число ");
int secondNumber =  Convert.ToInt32(Console.ReadLine());
// проверка первого со вторым и вывод результат в консоль
if (firstNumber > secondNumber )
    {Console.WriteLine(" первое число больше второго " + firstNumber + " > " + secondNumber);
}else if (firstNumber<secondNumber) 
         {Console.WriteLine(" второе число больше перого " + firstNumber + " < " + secondNumber);
    }else
         {Console.WriteLine(" числа равны " + secondNumber + " = " + firstNumber);}
