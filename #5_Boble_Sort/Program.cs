﻿Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Введите значение массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Исходный массив: [" + string.Join(", ", array) + "]");
Console.WriteLine();

for (int i = 0; i < n; i++)
{
    int temp = 0;
    for (int j = 0; j < n - 1; j++)
    { 
        if (array[j] > array[j + 1])
        {
            temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
        }
    }
    Console.WriteLine(i + "[" + string.Join(", ", array) + "]");
}