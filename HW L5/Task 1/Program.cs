﻿// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
void Print(int[] arr_1)
{
    int num = arr_1.Length;

    for (int i = 0; i < num; i++)
        Console.Write($"{arr_1[i]} ");
    
    Console.WriteLine();
}

int[] Massiv(int size)
{
    int[] arr_1 = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr_1[i] = new Random().Next(100,1000);
    }
    return arr_1;
}  

int Count(int[] arr_1)
{
    int count = 0;
    
    for (int i = 0; i < arr_1.Length; i++)
    {
        if (arr_1[i] % 2 == 0)
            count++; 
    }
    return count;
}

Console.WriteLine("Write the number of massiv alemebts");
int[] arr = Massiv(int.Parse(Console.ReadLine()));
Print(arr);
Console.WriteLine($"Count of even numbers {Count(arr)}");
