// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintTwoDimensionalArray(array);
Console.WriteLine();
double[] newArray = AverageNumbersArray(array);
PrintArray(newArray);

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

void PrintTwoDimensionalArray(int[,] inArray)
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

void PrintArray(double[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        Console.Write($"{inArray[i]} ");
    }

}

double[] AverageNumbersArray(int[,] inArray)
{
    double[] newMass = new double [inArray.GetLength(1)];
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < inArray.GetLength(0); j++)
        {
            sum = sum + inArray[j, i];
        }
        newMass[i] = Math.Round(sum / inArray.GetLength(0), 2);
    }
    return newMass;

}