﻿// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива
void Print(double[] arr_1)
{
    int num = arr_1.Length;

    for (int i = 0; i < num; i++)
        Console.Write($"{Math.Round(arr_1[i], 2)}  ");
    
    Console.WriteLine();
}

double[] Massiv(int size, double start, double finish)
{
    double[] arr_1 = new double[size];

    for (int i = 0; i < size; i++)
    {
        Random rnd = new Random();
        arr_1[i] = rnd.NextDouble() * (finish - start) + start;

    }
    return arr_1;
}  

double Raznost(double[] arr_1)
{
    double max = arr_1[0];
    double min = arr_1[0];
    
    for (int i = 1; i < arr_1.Length; i++)
    {
        if (arr_1[i] > max)
            max = arr_1[i] ; 
        if (arr_1[i] < min)
            min = arr_1[i];
    }
    
    Console.WriteLine($"Max = {Math.Round(max,2)}  Min = {Math.Round(min,2)}");
    return max - min;
}

double[] arr = Massiv(int.Parse(Console.ReadLine()),  // number of massiv alements
                      double.Parse(Console.ReadLine()),  // start
                      double.Parse(Console.ReadLine())); // finish
Print(arr);
Console.WriteLine($"Difference between max and min alements of massiv {Math.Round(Raznost(arr),2)}");
