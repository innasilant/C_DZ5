/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

double[] CreateAndFillArray(int size, int leftValue, int rightValue)
{
    double[] array = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(leftValue, rightValue);

    return array;
}

void PrintArrayInConsole(double[] array)
{
    Console.WriteLine(string.Join(",", array));
}

int MaxNumberMinusMinNumber(int[] array)
{
    int subtraction = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int minNumber = i;
        int maxNumber = i;
        if (array[i] > maxNumber) maxNumber = array[i];
        else if (array[i] < minNumber) minNumber = array[i];
    }
    return subtraction;
}
int size = 4;
double[] array = CreateAndFillArray(size, -9, 10);
PrintArrayInConsole(array);

double subtraction = MaxNumberMinusMinNumber(array);

Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {subtraction}");

