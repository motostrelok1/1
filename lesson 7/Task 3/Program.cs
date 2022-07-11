
// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем. 
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
// метод расчета пересечения
void IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * x + b2;
    Console.Write($"точка пересечения двух прямых ({x}, {y})");
}
//вводим координаты точек
Console.Write("введите точку b1: ");
double B1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите точку k1: ");
double K1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите точку b2: ");
double B2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите точку k2: ");
double K2 = Convert.ToInt32(Console.ReadLine());
IntersectionPoint(B1, K1, B2, K2);







// Console.WriteLine("Введите целое  число от 1 до 7, соответствующее дню недели");
// int day = 0;                                        // инициализация переменной 
// while (day <= 0 || day >= 8)                        // пока не введется правильный день, 
// {                                                   //будет повторяться цикл ввода, 
//     day = Convert.ToInt32(Console.ReadLine());      //пока не будет введено число 1-7
//     Console.WriteLine(" введи число от 1 до 7 ");
// }
// if (day == 6 || day == 7){                          //проверка на "выходной день"
//     Console.WriteLine(" Этот входной");
// }else{
//     Console.WriteLine( " Это будни");
// }