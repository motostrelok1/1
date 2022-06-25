// Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
// вводим количество элементов в массиве
System.Console.Write(" Введите количество элементов в массиве ");
int  n = Convert.ToInt32(Console.ReadLine());

// метод создает массив из n элементов и заполняет его случайными трехзначными числами
int[] FillArray(int n){
    int[] array = new int[n];
    for (int i = 0; i <array.Length; i++)
    {
      array[i] = new Random().Next(100,999); 
    }

    return array;
}
// метод проверяет массив  и считает количество четных элементов
int ChetSum(int[] array){
    int chet =0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0) chet++;
    }
    return chet;
} 
// инициируем массив
int[] arr = FillArray(n);
// проверяем массив на четность
int sum = ChetSum(arr);
//вывод в консоль результата
Console.Write("[{0}]" + " количество четных элементов = " + sum, string.Join(", ", arr));
