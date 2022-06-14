// See https://aka.ms/new-console-template for more information
Console.WriteLine("привет эта программ принимает на вход трехзначное число");

int Rand(out int randomNumber){
    int randomNumber = new Random().Next(100,1000);
//  Console.WriteLine(randomNumber+" "+(randomNumber%100/10));
//  int result = randomNumber % 10;
//  Console.WriteLine("   ");
return randomNumber;
}

//int[] arr = new int[3];
// for (int i = 0; i < 3; i++)
// {
//    arr[i]=Rand.randomNumber;
//    Console.WriteLine(arr[i]);
// }
Console.Writeline(Rand.randomNumber());




// See https://aka.ms/new-console-template for more information
Console.WriteLine("arrays example");

void FillArray(int[] collection){
    int lenth = collection.Length;
    int index = 0;
    while (index<lenth){
        collection[index] = new Random().Next(1,10);
        index++;
    }

}

void PrintArray(int[] col){
    int count = col.Length;
    int position = 0;
    while (position<count)
    {
        Console.Write(" " + col[position]);
        position++;
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);