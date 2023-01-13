// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
string[,] matrix = new string[4, 4];
string[,] FillMatrix(string[,] matr1)
{
    matr1[0, 0] = "01";
    matr1[0, 1] = "02";
    matr1[0, 2] = "03";
    matr1[0, 3] = "04";

    matr1[1, 0] = "12";
    matr1[1, 1] = "13";
    matr1[1, 2] = "14";
    matr1[1, 3] = "05";

    matr1[2, 0] = "11";
    matr1[2, 1] = "16";
    matr1[2, 2] = "15";
    matr1[2, 3] = "06";

    matr1[3, 0] = "10";
    matr1[3, 1] = "09";
    matr1[3, 2] = "08";
    matr1[3, 3] = "07";
    return matr1;
}

void PrintArray(string[,] matr)
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
PrintArray(FillMatrix(matrix));