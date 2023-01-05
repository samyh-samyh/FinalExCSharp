// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо 
// задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

using System;
using static System.Console;

Clear();

string[] first = new string[] { "Hello", "2", "world", ":-)" };
string[] final = new string[first.Length];
int SizeStringToShow = 3;

void FillArr(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= SizeStringToShow)
        {
            arr2[count] = arr1[i];
            count++;
        }
    }
}
void PrintArr(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Write($"{arr[i]} ");
    }
    WriteLine();
}
FillArr(first, final);
PrintArr(final);
