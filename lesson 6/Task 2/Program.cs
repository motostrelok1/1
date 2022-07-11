
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101, 3 -> 11

Console.Clear();
// метод конвертирует десятичное число в двоичное
int[] ConvertingDecimalToBinary(int size, int number)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = number % 2;
        number /= 2;
    }
    return arr;
}
//метод определения размера массива
int ArraySize(int number)
{
    int count = 0;
    while (number > 0)
    {
        number /= 2;
        count++;
    }
    return count;
}
// метод разворачивает массив и выводит в консоль
void ReverseAndPrintArray(int[] ar, int number)
{
    Console.Write(" число " + number + " в двоичном формате будет ");
    for (int j = ar.Length - 1; j >= 0; j--) Console.Write(ar[j]);
}

Console.Write("Введите десятичное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int s = ArraySize(number);
int[] myArray = ConvertingDecimalToBinary(s, number);
ReverseAndPrintArray(myArray, number);
