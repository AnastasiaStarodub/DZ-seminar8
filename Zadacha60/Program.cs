// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int Numb(string message)
{
    Console.WriteLine(message);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

void RandomArray(int[,,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            for (int k = 0; k < arg.GetLength(2); k++)
            {
                arg[i, j, k] = new Random().Next(1, 100);
            }
        }
    }
}

void PrintArray(int[,,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < arg.GetLength(2); k++)
            {
                Console.Write($"{arg[i, j, k]}({i},{j},{k}) ");
            }
        }
        
    }
    Console.WriteLine();
}

Console.Clear();
int rows = Numb($"Введите длину строк: ");
int columns = Numb($"Введите длину столбцов: ");
int page = Numb($"Введите количество страниц: ");
int[,,] array = new int[rows, columns, page];
Console.WriteLine();
RandomArray(array);
PrintArray(array);
