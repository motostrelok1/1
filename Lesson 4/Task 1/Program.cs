// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
//в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
System.Console.WriteLine();

// ввод данных
Console.WriteLine(" Введите целое число А ");
var num = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" Введите целое число В ");
var pow = Convert.ToDouble(Console.ReadLine());

// вывод в консоль
Console.WriteLine(" Число " + num + " возведенное в степень " + pow + " = " + Math.Pow(num,pow));