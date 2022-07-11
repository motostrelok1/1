// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
// метод считает количество положительных чисел
void AmountOfPositiveNumbers(int M){
    int count = 0;
    for (int i = 0; i < M; i++)
    {
        Console.Write($"Input {i + 1} number - ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0)
            count++;
    }
    Console.WriteLine("Amount of positive numbers = " + count);
}
// запрашиваем количество чисел для сравнения
Console.Write("Сколько числе будуту вводить? ");
int m = Convert.ToInt32(Console.ReadLine());
AmountOfPositiveNumbers(m);

