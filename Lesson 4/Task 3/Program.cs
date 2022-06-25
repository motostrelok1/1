// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
System.Console.WriteLine();

// метод создает массив из 8 элементов и заполняет его случайными числами
int[] FillArray(){
    int[] array = new int[8];
    for (int i = 0; i <array.Length; i++)
    {
      array[i] = new Random().Next(0,99);  
    }
    return array;
}
// инициируем массив
int[] arr = FillArray();
//вывод в консоль массива
Console.WriteLine("[{0}]", string.Join(", ", arr));