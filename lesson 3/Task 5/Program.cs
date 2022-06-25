//Напишите программу, которая принимает на вход два числа 
//и проверяет, является ли одно число квадратом другого.

Console.Clear();
// ввод чисел
System.Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

//проверка и вывод
if (number1 == (number2 * number2)){
    System.Console.WriteLine("Число " + number1 + " является квадратом числа " + number2);  
}else{
    System.Console.WriteLine("Число " + number1 + " не является квадратом числа " + number2);}
