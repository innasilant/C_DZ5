/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] CreateAndFillArray(int size, int leftValue, int rightValue)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(leftValue, rightValue);

    return array;
}

void PrintArrayInConsole(int[] array)
{
    Console.WriteLine(string.Join(",", array));
}

int GetSumNumbersInOddPosition(int[] array)
{
    int amounts = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            amounts += array[i];
    }
    return amounts;
}

int size = 6;
int[] array = CreateAndFillArray(size, -10, 11);
PrintArrayInConsole(array);
int amounts = GetSumNumbersInOddPosition(array);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {amounts}");

