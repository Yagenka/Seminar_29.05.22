// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк - ");
int row = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов - ");
int column = int.Parse(Console.ReadLine());

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



  


double GetSrSum(int[,] array)
{
    double sum = 0;
int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
    
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
                sum = sum + array[i, j];
               
                          
        }
          Console.WriteLine(sum);
sum = sum / array.GetLength(1); 
    }


    return sum;
}



int[,] arrayResult = GetArray(row, column);
PrintArray(arrayResult);
double sunsr = GetSrSum(arrayResult);
Console.Write(sunsr);


