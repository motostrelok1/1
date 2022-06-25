// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
// вводим количество элементов в массиве
System.Console.Write(" Введите количество элементов в массиве ");
int  n = Convert.ToInt32(Console.ReadLine());

// метод создает массив из n элементов и заполняет его случайными вещественными числами
double[] FillArray(int n){
    int c = 0;
    double[] array = new double[n];
    for (int i = 0; i <array.Length; i++)
    {
      array[i] = new Random().NextDouble(); //делаем число от 0 до 1
      c = new Random().Next(0,99);          // делаем рандомное целое число
      array[i] = Math.Round((array[i]+c),2);// соединяем целую и дробную части и округляем до 2го знака
    }
  return array;
}

// инициируем массив
double[] arr = FillArray(n);

//вывод в консоль массива, и разницы мах min элементов и округляем до второго знака
Console.Write("[ {0} ]" + " разница min и max элементами массива = ", string.Join("   ", arr));
Console.WriteLine(arr.Max() + " - " + arr.Min() + " = " + Math.Round((arr.Max()-arr.Min()),2));