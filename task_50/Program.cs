﻿// Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();
Console.Write("Введите номер строки нужного элемента массива (нумерация строк начинается с 1): ");
int row = int.Parse(Console.ReadLine());

Console.Write("Введите номер столбца нужного элемента массива (нумерация столбцов начинается с 1): ");
int column = int.Parse(Console.ReadLine());
Console.WriteLine();
int[,] array = GetArray(5, 5, 0, 10);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(FindElement(array, row, column));

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }

}

string FindElement(int[,] inArray, int r, int c)
{
    string text = "";
    if(r - 1 >= inArray.GetLength(0) || c - 1 >= inArray.GetLength(1))
    {
        text = $"Элемент на пересечении строки {r} и столбца {c} в массиве отсутствует.";
    }
    else
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                text = $"Элемент на пересечении строки {r} и столбца {c} в массиве равен {inArray[r - 1, c - 1]}.";
            }
        }
    }
    return text;
}
