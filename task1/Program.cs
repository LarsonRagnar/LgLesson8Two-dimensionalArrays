// // string test = "";
// // string test= String.Empty;  // задание пустой строчки так вернее

// int max; // просто иницилизируем пустую численую переменную чтоб потом присвоить ей значение


//int[] array = {10,20,30,10,55,44,88};
//int max = int.MinValue; //универсальное решение для инициальзации для дальнейших операций
//int min = int.MaxValue; // тоже самое в обратную сторону

// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] resultMatrix= GetMatrix(5,5,10,100);

PrintMatrix(resultMatrix);
Console.WriteLine("Результирующая матрица");
ChangeRows(resultMatrix);
PrintMatrix(resultMatrix);

/// <summary>
/// Этот метод заполняет двумерный массив числами от Min до max
/// </summary>
/// <param name="rows">Количество строк</param>
/// <param name="cols">количество столбцов</param>
/// <param name="min">Мин значение</param>
/// <param name="max">Макс значение</param>
/// <returns>Заполненый двумерный массив целых чисел</returns> 
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

/// <summary>
/// Метод печатает матрицу, которую передали
/// </summary>
/// <param name="InputMatrix">Двумерный массив или таблица</param>
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

/// <summary>
/// Метод ищет последюю строчку и меняет ее на первую и наоборот
/// </summary>
/// <param name="matr">матрица двумерныйМассив</param>
void ChangeRows(int[,] matr)
{
    int lastRow=matr.GetLength(0) -1; // индекс последней 
    for (int i = 0; i < matr.GetLength(1); i++) // элемент таблицы из 0 строчку i столбца
    {
        int temp = matr[0,i]; // элемент таблицы из 0 строчку i столбца
        matr[0,i]= matr[lastRow,i]; // элемент из 0 строчки i столбца = элемнет из последней строчки 
        matr[lastRow,i]= temp; // элемент из последней строчки = temp
    }

}

