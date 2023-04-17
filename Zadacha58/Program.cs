// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int Numb(string message)
{
    Console.WriteLine(message);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

void RandomArray(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            arg[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] arg)
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

void ProductArrays(int[,] arg, int[,] arg2,int[,] result)
{
if (arg.GetLength(0) != arg2.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < arg.GetLength(0); i++)
{
    for (int j = 0; j < arg2.GetLength(1); j++)
    {
        result[i, j] = 0;
        for (int k = 0; k < arg.GetLength(1); k++)
        {
            result[i, j] += arg[i, k] * arg2[k, j];
        }

    }         
}
}

Console.Clear();
int rows = Numb($"Введите длину строк: ");
int columns = Numb($"Введите длину столбцов: ");
int[,] array = new int[rows, columns];
int[,] array2 = new int[rows, columns];
int[,] result = new int[rows, columns];
Console.WriteLine();
RandomArray(array);
RandomArray(array2);
PrintArray(array);
PrintArray(array2);
ProductArrays(array, array2, result);
PrintArray(result);
