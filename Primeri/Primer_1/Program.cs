// Задача 1. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
double[,] GenerateArray(int n, int m)
{
    double[,] array = new double[n, m]; 
    Random random = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-99, 100) / 10.0;
        }
    }
    return array;
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

Console.WriteLine("Введите количество строк -> ");
int n = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите количество столбцов -> ");
int m = Convert.ToInt32(Console.ReadLine());
double[,] arraymn = GenerateArray(n,m);
PrintArray(arraymn);