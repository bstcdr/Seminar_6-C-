// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//5 2 6 7

//Программа считает сумму элементов в каждой строке и 
//выдаёт номер строки с наименьшей суммой элементов: 1 строка
int[,] matrix = new int[4, 4];
matrix[0, 0] = 1;       //1 4 7 2
matrix[0, 1] = 4;       //5 9 2 3
matrix[0, 2] = 7;       //8 4 2 4
matrix[0, 3] = 2;       //5 2 6 7

matrix[1, 0] = 5;
matrix[1, 1] = 9;
matrix[1, 2] = 2;
matrix[1, 3] = 3;

matrix[2, 0] = 8;
matrix[2, 1] = 4;
matrix[2, 2] = 2;
matrix[2, 3] = 4;

matrix[3, 0] = 5;
matrix[3, 1] = 2;
matrix[3, 2] = 6;
matrix[3, 3] = 7;

void Sums(int[,] matr)
{
    int sum1 = matr[0, 0] + matr[0, 1] + matr[0, 2] + matr[0, 3];
    int sum2 = matr[1, 0] + matr[1, 1] + matr[1, 2] + matr[1, 3];
    int sum3 = matr[2, 0] + matr[2, 1] + matr[2, 2] + matr[2, 3];
    int sum4 = matr[3, 0] + matr[3, 1] + matr[3, 2] + matr[3, 3];
    
    int[] sums = new int[4];
    sums[0] = sum1;
    sums[1] = sum2;
    sums[2] = sum3;
    sums[3] = sum4;
    int min = 0;
    for (int i = 1; i < 4; i+=1)
    {
        if (sums[min] > sums[i]) min = i;
        
    }
    Console.WriteLine($"{min+1} строка");

}
Sums(matrix);
