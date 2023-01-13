// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
int[,] matrix = new int[3, 4];
matrix[0, 0] = 1;       //1 4 7 2
matrix[0, 1] = 4;       //5 9 2 3
matrix[0, 2] = 7;       //8 4 2 4
matrix[0, 3] = 2;      

matrix[1, 0] = 5;
matrix[1, 1] = 9;
matrix[1, 2] = 2;
matrix[1, 3] = 3;

matrix[2, 0] = 8;
matrix[2, 1] = 4;
matrix[2, 2] = 2;
matrix[2, 3] = 4;

int[,] SortArray(int[,] matr)
{
    int max = matr[0, 0];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int l = j + 1; l < matr.GetLength(1); l++)
            {
                if (matr[i, j] < matr[i, l])
                {
                int temp = matr[i, j];
                matr[i, j] = matr[i, l];
                matr[i, l] = temp;
                }
            }
        }     
    }
    return matr;
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

PrintArray(SortArray(matrix));