// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

Console.Clear();
//создаем массив на 3 элемента
int[] arr = new int[3];

// вызов методов
FillArray(arr);
PrintArray(arr);

// метод заполняющий массив случайными числами
void FillArray(int[] arr){
    int i = 0;
    while (i<arr.Length){
        arr[i] = new Random().Next(100,1000);
        i++;
    }
}
// метод выводящий в консоль среднюю цифру каждого элемента массива 
void PrintArray(int[] arr){
    int i = 0;
    while (i<arr.Length)
    {
        Console.WriteLine(" " + arr[i] + " средняя цифра " + (arr[i]%100/10));
        i++;
    }
}
