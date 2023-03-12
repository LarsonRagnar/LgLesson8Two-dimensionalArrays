// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество строк");
// int cols = Convert.ToInt32(Console.ReadLine());

// int[,] GetMatrix(int rows, int cols, int min, int max)
// {
//     int[,] matrix = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] InputMatrix)
// {
//     for (int i = 0; i < InputMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < InputMatrix.GetLength(1); j++)
//         {
//             Console.Write(InputMatrix[i,j]+ "\t");
//         }
//         Console.WriteLine();
//     }
// }

int rows = 3;
int cols = 3;
int[,] matrix = new int[rows, cols] ;
int min= int.MaxValue;
int indexMinRows= 0;
int indexMinCols= 0;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        matrix[i,j]= new Random().Next(11);
        Console.Write(matrix[i,j]+ "\t");
        if (min>matrix[i,j])
        {
            min=matrix[i,j];
            indexMinRows=i;
            indexMinCols=j;
        }
    }
    Console.WriteLine();
}
Console.WriteLine($"Мин элемент: {min}, \n строчка {indexMinRows}, \n столб: {indexMinCols}");
for (int i = 0; i < rows; i++)
{
    if (i!= indexMinRows)
    {
        for (int j = 0; j < cols; j++)
        {
            if (j!=indexMinCols)
            {
                Console.Write(matrix[i,j]+ "\t");
            }
        }
        Console.WriteLine();
    }
}