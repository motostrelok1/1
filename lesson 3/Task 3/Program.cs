// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();
System.Console.WriteLine();

// сначало вводим число N для создания количества элементов таблицы(массива)
System.Console.Write("Введите число, таблицу кубов которого хотите увидеть:   ");
int N = Convert.ToInt32(Console.ReadLine());

// создаем метод который заполняет массив в котором лежат сами кубы и возвращает этот массив
int[] GetCubeTable(int N)
{
    int[] cubs = new int[N];
    int number = 1;
    for (int i = 0; i < N; i++)
    {
        cubs[i] = number * number * number;
        number++;
    }
    return cubs;
}

// создаем метод, который выводит на экран таблицу кубов используя кубы из массива созданного выше
void PrintCubs(int[] array)
{
    int number = 1;
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine(number+" ^ 3 = "+array[i]+"  ");
        number++;
    }
}
// создаем массив, заполняем его методом GetCubTable и выводим в консоль
int[] CubeTable = GetCubeTable(N);
PrintCubs(CubeTable);

