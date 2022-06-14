// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

int[] arr = new int[3];

FillArray(arr);
PrintArray(arr);


void FillArray(int[] arr){
    int i = 0;
    while (i<arr.Length){
        arr[i] = new Random().Next(100,1000);
        i++;
    }
}

void PrintArray(int[] arr){
    int i = 0;
    while (i<arr.Length)
    {
        Console.WriteLine(" " + arr[i] + " среднее число " + (arr[i]%100/10));
        i++;
    }
}
