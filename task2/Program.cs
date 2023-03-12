// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк");
int cols = Convert.ToInt32(Console.ReadLine());
if (rows!=cols)
{
    Console.WriteLine("нельзя заменить строки столбцами матрица НЕ квадратная");
    return;
    
}

int[,] resultMatrix= GetMatrix(rows,cols,10,100);
PrintMatrix(resultMatrix);
Console.WriteLine("РЕЗУЛЬТАТ");
int[,] copyMatrix= ChangeArray(resultMatrix);
PrintMatrix(copyMatrix);



int[,] GetMatrix(int rows, int cols, int min, int max)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] InputMatrix)
{
    for (int i = 0; i < InputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < InputMatrix.GetLength(1); j++)
        {
            Console.Write(InputMatrix[i,j]+ "\t");
        }
        Console.WriteLine();
    }
}

int[,] ChangeArray(int [,] matrix)
{
    int[,] copyMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < copyMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < copyMatrix.GetLength(1); j++)
        {
            copyMatrix[i, j] = matrix[j,i];
        }
    }
    return copyMatrix;
}