// Напишите программу, которая на вход принимает число (N), а
// на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Привет, это программа показывает все четные числа, которые содержатся в веденном числе");

Console.WriteLine(" Введи положительное целое число ");
int number =  Convert.ToInt32(Console.ReadLine());                 // вводим число для проверки на четность
Console.Write(" В числе " + number + " содержутся четные числа: ");// вывод в консоль
for (int i = 2; i <= number; i++)                                  // цикл начинается с 2, т.к. 1 не четное число. цикл перебора на четность
{
    if ((i % 2) == 0)                                              // проверка каждого элемента цикла на четность
    {
        Console.Write(" " + i + " ");                              // если число четное, выводим в консоль
    }
}
    
