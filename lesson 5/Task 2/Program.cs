// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0){ sum = sum + array[i];}
    }
    return sum;
} 
// инициируем массив
int[] arr = FillArray(n);
// проверяем массив на четность
int sum = ChetSum(arr);
//вывод в консоль результата
Console.Write("[{0}]" + " сумма четных элементов = " + sum, string.Join(", ", arr));