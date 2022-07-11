//Напишите программу, которая на вход принимает позиции элемента
//в двумерном массиве, и возвращает значение этого элемента или 
// указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

Console.Clear();
// метод генирирует двумерный массив
int[,] GenArray(){
    Console.WriteLine(" двумерный массив представлен в виде таблицы");
    Console.Write("Введите число строк : ");
    int m = int.Parse(Console.ReadLine ());
    Console.Write("Введите число столбцов: ");
    int n = int.Parse(Console.ReadLine ());
    int[,] arr = new int[m, n];
    Random rand = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = rand.Next(0, 10);
        }

    }
    return arr;
}
// метод выводит массив в консоль
void PrintArray(int[,] prarr)
{
    for (int i = 0; i < prarr.GetLength(0); i++)
    {
        for (int j = 0; j < prarr.GetLength(1); j++)
        {
            Console.Write(prarr[i,j] + " ");
        }
        Console.WriteLine();
    }
}
// метод запрашивает и выводит элемент массива
void GetElemArray(int[,] arr)
{
    Console.WriteLine(" для вывода задуманного элемента массива");
    Console.Write("введите номер строки: ");
    int m = (int.Parse(Console.ReadLine ()))-1;
    Console.Write("введите номер столбца: ");
    int n = (int.Parse(Console.ReadLine ()))-1;
    string res =  m < arr.GetLength(0) && n < arr.GetLength(1)? $"{arr[m, n]}" : $"array[{m}, {n}] -->  такого элемента в массиве нет";
    Console.WriteLine(res);
}
// метод ищет значение по элементам массива
void FindNumArray(int[,] arr){
    Console.Write("Введите число, для поиска его в заданном массиве: ");
    int num = int.Parse(Console.ReadLine ());
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i,j] == num)
            {
                Console.WriteLine($"{num} -> число есть в массиве");
                return;
            }
        }
    }
    Console.WriteLine($"{num} -> такого числа в массиве нет");
}

int[,] array = GenArray();
PrintArray(array);
GetElemArray(array);
PrintArray(array);
FindNumArray(array);
