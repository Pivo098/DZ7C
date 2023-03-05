// Задача 3. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[,] GenerateArray(int r, int c)
{
    double[,] array = new double[r, c]; 
    Random random = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-9, 10);
        }
    }
    return array;
}

void PrintArray1(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " \t");
    }
    Console.WriteLine();
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
    }
    System.Console.WriteLine();
}
double[,] array = GenerateArray(4,5);
PrintArray(array);

double[] avgnum = new double[array.GetLength(1)];
for (int i = 0; i < array.GetLength(1); i++)
{
    double result = 0.0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        result += array[j, i];
    }
    avgnum[i] = result / array.GetLength(0);
}
System.Console.WriteLine();
PrintArray1(avgnum);