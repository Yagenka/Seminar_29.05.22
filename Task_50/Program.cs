// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


Console.Write("Введите количество строк - ");
int row = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов - ");
int column = int.Parse(Console.ReadLine());

Console.Write("Введите искомую позицию в строках - ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите искомую позицию в столбцах - ");
int b = int.Parse(Console.ReadLine());

int[,] GetArray(int a, int b)
{
    int[,] array = new int[a, b];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


void GetZnacheniePoPosicii(int[,] array, int a, int b)
{
    if (a > array.GetLength(0) || b > array.GetLength(1))
    {
        Console.WriteLine("нет такого элемента");
    }
    else     Console.WriteLine($"Значение в этом элементе -  {array[a, b]}");
}

int[,] arrayResult = GetArray(row, column);
PrintArray(arrayResult);
GetZnacheniePoPosicii(arrayResult, a, b);
