/* Задача 52**_. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/


Console.WriteLine("Нахождение среднего арифметического");
Console.WriteLine("значений каждого столбца заданного массива:");
int[,] Array = GetArray();
PrintSpace();
PrintArray(Array);
PrintSpace();
Console.WriteLine("среднее арифметическое");
PrintSpace();
ArithmeticMeanColumn(Array);

int[,] GetArray()
{
    int[,] array = new int[6, 4];
    Random rnd = new ();
    for (int i = 0; i < 6; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

void ArithmeticMeanColumn (int[,] Array)
{
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            sum += Array[i, j];           
        }
        Console.Write($" {Math.Round (((double)sum / (double)Array.GetLength(0)),2)} ");
    }
    
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"  {array[i, j]}   ");
        }
        Console.WriteLine();
    }

}
void PrintSpace()
{
    Console.WriteLine();
}
