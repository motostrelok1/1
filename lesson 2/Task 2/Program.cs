// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
Console.Clear();
//создаем массив из 3х элементов
int[] arr = new int[3];                                             

// вызов метода
FillArray(arr);  
PrintArray(arr);

// метод заполняет массив случайными числами от 10 до 1000
void FillArray(int[] arr){
    int i = 0;
    while (i<arr.Length){
        arr[i] = new Random().Next(10,1000);
        i++;
    }
}
// метод проверяет выводит 3ю цифру каждого элемента массива 
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
