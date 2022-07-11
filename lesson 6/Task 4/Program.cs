// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Clear();

int num = Input("Введите число N: ");
int[] arr = new int[num]; // задаем размер массива

arr[0] = 0; // задаем 0й элемент =0
if (num == 1)
{
    Console.WriteLine(arr[0]);
}
else
{
    arr[1] = 1; // задаем 1й элемент =1
    for (int i = 2; i < num; i++)// заполняем значениями фибоначи массив
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    PrintArray(arr);// вызов метода вывода

// Метод вывода массива
    void PrintArray(int[] array)
    {
        string print = "[";
        for (int i = 0; i < array.Length; i++)
        {
            if (i == array.Length - 1)
            {
                print += array[i];
                break;
            }
            print += array[i] + ", ";
        }
        Console.Write(print + "]\n");
    }
}
// метод ввода числа
int Input(string str)
{
    Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

