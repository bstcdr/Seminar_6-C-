// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.


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

int[,] TransposedMatrix(int[,] mat)
{
    int a = mat.GetLength(1);
    int b = mat.GetLength(0);
   
    int[,] ReverseMatrix = new int[a, b];
    for (int i = 0; i < a; i++) 
    {
        for (int j = 0; j < b; j++)
        {
            ReverseMatrix[i, j] = mat[j, i];
        }
    }
    return ReverseMatrix;
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
PrintArray(TransposedMatrix(matrix));