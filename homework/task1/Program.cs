// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2-> 2

//1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите числа через запятую: ");
string numbers = (Console.ReadLine());

string[] array = numbers.Split(",");



int PositiveNumCount(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (int.Parse(array[i]) > 0) count = count + 1;
    }
    return count;
}

Console.WriteLine(PositiveNumCount(array));