// See https://aka.ms/new-console-template for more information
Console.WriteLine("привет эта программ принимает на вход трехзначное число");

void Rand(){
    int randomNumber = new Random().Next(100,1000);
//  Console.WriteLine(randomNumber+" "+(randomNumber%100/10));
//  int result = randomNumber % 10;
//  Console.WriteLine("   ");
//return randomNumber;
}

int[] arr = new int[3];
// for (int i = 0; i < 3; i++)
// {
//    arr[i]=Rand.randomNumber;
//    Console.WriteLine(arr[i]);
// }
Console.Writeline(Rand.randomNumber());