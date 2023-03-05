// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int[,] GenerateArray(int r, int c)
{
    int[,] array = new int[r, c]; 
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

void PrintArray(int[,] array)
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
Console.WriteLine("Введите индекс строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите индекс столбца: ");
int colums = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
int[,] arraymn = GenerateArray(4,5);
if (rows < arraymn.GetLength(0) && colums < arraymn.GetLength(1)) Console.WriteLine(arraymn[rows, colums]);
else Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");
PrintArray(arraymn);




