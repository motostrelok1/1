﻿// See https://aka.ms/new-console-template for more information
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