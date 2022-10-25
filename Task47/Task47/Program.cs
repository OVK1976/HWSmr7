/* Задача 47. Задайте двумерный массив размером m×n, 
 * заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */

// TODO Повторно: разобрать создание двумерного массива
#region CreateNewArray // Создание массива чисел
double[] CreateArray(int size)
{
    double[] array = new double[size];
    Random random = new();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(random.NextDouble() * random.Next(int.MinValue, int.MaxValue), 2);
    }
    return array;
}
#endregion


// TODO Доработать для двумерного массива

#region WriteArrayToString // Вывод элементов массив
string ArrayToString(int[] array)
{
    string result = "[";

    for (int i = 0; i < array.Length; i++)
        if (i == array.Length - 1)
        {
            result += $"{array[i]}";
        }
        else
        {
            result += $"{array[i]}, ";
        }

    result += "]";
    return result;
}

#endregion