/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

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

int AmountOfEvenNumbers(int[] array)
{
    int amount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            amount +=1;
    }
    return amount;
}

int size = 4;
int[] array = CreateAndFillArray(size, 100, 1000);
PrintArrayInConsole(array);
int amount = AmountOfEvenNumbers(array);
Console.WriteLine($"Количество четных чисел в массиве = {amount}");

