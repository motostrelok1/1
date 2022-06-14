// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

int[] arr = new int[3];

FillArray(arr);
PrintArray(arr);


void FillArray(int[] arr){
    int i = 0;
    while (i<arr.Length){
        arr[i] = new Random().Next(10,1000);
        i++;
    }
}

void PrintArray(int[] arr){
    int i = 0;
    while (i<arr.Length)
    {
        if (99<arr[i])
        {
           Console.WriteLine(" " + arr[i] + " третья цифра " + (arr[i]%10)); 
        }else{
            Console.WriteLine(" " + arr[i] + " третьей цифры нет ");
        }
        
        i++;
    }
}
