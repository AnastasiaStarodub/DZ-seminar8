// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
//Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

int Numb(string message)
{
    Console.WriteLine(message);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

void RandomArray(int[,] arg)
{
    {
        for (int i = 0; i < arg.GetLength(0); i++)
        {
            for (int j = 0; j < arg.GetLength(1); j++)
            {
                arg[i, j] = new Random().Next(1, 10);
            }
        }
    }
}

void PrintArray(int[,] arg)
{
    if (arg.GetLength(0) == arg.GetLength(1))
    {
        Console.WriteLine("Задайте прямоугольный массив!");
    }
    else
    {
        for (int i = 0; i < arg.GetLength(0); i++)
        {
            for (int j = 0; j < arg.GetLength(1); j++)
            {
                Console.Write($"{arg[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void MinSumRow(int[,] arg)
{
    if (arg.GetLength(0) == arg.GetLength(1)) Console.WriteLine("");
    else
    {
        int minRow = 0;
        int minSummaRow = 0;
        int sumRow = 0;
        for (int i = 0; i < arg.GetLength(1); i++)
        {
            minRow += arg[0, i];
        }
        for (int i = 0; i < arg.GetLength(0); i++)
        {
            for (int j = 0; j < arg.GetLength(1); j++)
                sumRow += arg[i, j];
            if (sumRow < minRow)
            {
                minRow = sumRow;
                minSummaRow = i;
            }
            sumRow = 0;
        }
        Console.Write($"Номер строки с наименьшей суммой элементов: {minSummaRow + 1}");
    }
}

Console.Clear();
int rows = Numb($"Введите длину строк: ");
int columns = Numb($"Введите длину столбцов: ");
int[,] array = new int[rows, columns];
Console.WriteLine();
RandomArray(array);
PrintArray(array);
MinSumRow(array);
