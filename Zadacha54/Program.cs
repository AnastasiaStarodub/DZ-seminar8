// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
            arg[i, j] = new Random().Next(1, 100);
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

void ChangeArray(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            for (int k = 0; k < arg.GetLength(1) - 1; k++)
            {
                if (arg[i, k] < arg[i, k + 1])
                {
                    int temp = arg[i, k + 1];
                    arg[i, k + 1] = arg[i, k];
                    arg[i, k] = temp;
                }
            }
        }
    }
}


Console.Clear();
int rows = Numb($"Введите длину строк: ");
int columns = Numb($"Введите длину столбцов: ");
int[,] array = new int[rows, columns];
Console.WriteLine();
RandomArray(array);
PrintArray(array);
ChangeArray(array);
PrintArray(array);