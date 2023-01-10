// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//17->такого числа в массиве нет
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int[,] matrix = new int[3, 4];
matrix[0, 0] = 1;
matrix[0, 1] = 4;
matrix[0, 2] = 7;
matrix[0, 3] = 2;

matrix[1, 0] = 5;
matrix[1, 1] = 9;
matrix[1, 2] = 2;
matrix[1, 3] = 3;

matrix[2, 0] = 8;
matrix[2, 1] = 4;
matrix[2, 2] = 2;
matrix[2, 3] = 4;

void PrintElementValue(int[,] matr)
{
    int row = -5;
    int col = -5;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matrix[i, j] == a)
            { row = i; col = j; }
            if (row >= 0 | col >= 0) Console.WriteLine($"({row},{col})");
            row = -1; //значение row и col изменяется на отрицательное на случай, если есть еще одно данное пользователем значение в текущей строке
            col = -1; // например в строке индексом 2, имеются 2 элемента со значением 4
            
        }
    }
    Console.WriteLine("Конец");
}
PrintElementValue(matrix);