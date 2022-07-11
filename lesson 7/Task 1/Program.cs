//Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.

Console.Clear();

// метод создает двумерный массив
double [,] GenDoubleArray()
{
    Console.Write("Введите число строк массива: ");
    int m = int.Parse(Console.ReadLine ());
    Console.Write("Введите число столбцов массива: ");
    int n = int.Parse(Console.ReadLine ());
    double[,] arr = new double[m, n];
    Random rand = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = Math.Round(rand.Next(-10, 11) * rand.NextDouble(), 1);
        }

    }
    return arr;
}
// метод выводит в консоль двумерный массив
void PrintDoubleArray(double[,] prarr)
{
    for (int i = 0; i < prarr.GetLength(0); i++)
    {
        for (int j = 0; j < prarr.GetLength(1); j++)
        {
            Console.Write(prarr[i,j] + "\t");
        }
        Console.WriteLine();
    }
}


double[,] array = GenDoubleArray();
PrintDoubleArray(array);
