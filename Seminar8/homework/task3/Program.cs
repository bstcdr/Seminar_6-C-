// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int[,] matrix1 = new int[2, 2];
matrix1[0, 0] = 2;
matrix1[0, 1] = 4;
matrix1[1, 0] = 3;
matrix1[1, 1] = 2;

int[,] matrix2 = new int[2, 2];
matrix2[0, 0] = 3;
matrix2[0, 1] = 4;
matrix2[1, 0] = 3;
matrix2[1, 1] = 3;

int[,] Mulitply(int[,] matr1, int[,] matr2)
{
    int[,] matr3 = new int[matr1.GetLength(0), matr2.GetLength(1)];
    matr3[0, 0] = matr1[0, 0] * matr2[0, 0] + matr1[0, 1] * matr2[1, 0];    
    matr3[0, 1] = matr1[0, 0] * matr2[0, 1] + matr1[0, 1] * matr2[1, 1];
    matr3[1, 0] = matr1[1, 0] * matr2[0, 0] + matr1[1, 1] * matr2[1, 0];
    matr3[1, 1] = matr1[1, 0] * matr2[0, 1] + matr1[1, 1] * matr2[1, 1];
    return matr3;
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

PrintArray(Mulitply(matrix1, matrix2));
