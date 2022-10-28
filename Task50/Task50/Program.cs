/*Задача 50. Напишите программу, которая на вход принимает позиции элемента 
 в двумерном массиве, и возвращает значение этого элемента 
 или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17->такого числа в массиве нет */

Console.WriteLine("Поиск значения в двумерном массиве");
Console.WriteLine("Введите строку (от 1): ");
int i= int.Parse(Console.ReadLine());
Console.WriteLine("Введите столбец (от 1): ");
int j = int.Parse(Console.ReadLine());
Console.WriteLine();
Random rnd = new Random();
int m = rnd.Next(2,10);
int n = rnd.Next(2,10);
int[,] FirstArray = GetArray(m,n);
Console.WriteLine ("Результаты поиска элемента в массиве: ");
Console.WriteLine();
PrintArray(FirstArray);
Console.WriteLine();
FindElementArray(FirstArray, i, j);

int[,] GetArray(int m, int n)
{
        int [,] array = new int [m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-20, 20);
        }
    }
    return array;
}
void FindElementArray (int [,] array, int i, int j)
{
    if (i>array.GetLength (0) || j>array.GetLength (1))
    {
        Console.WriteLine($"Элемента в массиве нет");
    }
    else
    {
        Console.Write($"Элемент равен: {array[i-1,j-1]} ");        
    }
}

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }

}