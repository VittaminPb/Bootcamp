// задан массив 1 5 4 1 3 4 7 4 1 2
// m = 3 - найти максимальную сумму m подряд элементов
// в данном массиве max = 15

using System.Diagnostics;

int size = 10;

int m = 3;

int[] array = Enumerable.Range(1, size) //задаем массив со значениями элементов от 1 до size
                        .Select(item => Random.Shared.Next(10)) // 10 элементов массива
                        .ToArray();

Console.WriteLine($"[{string.Join(", ", array)}]"); // вывод массива

Stopwatch sw = new();
sw.Start();

int max = 0;
for (int j = 0; j < m; j++) max += array[j];
int t = max;
for (int i = 1; i < array.Length - m; i++)
{
    t = t - array[i - 1] + array[i + (m - 1)];
    if (t > max) max = t;
}

sw.Stop();

Console.WriteLine($"time = {sw.ElapsedMilliseconds}");
Console.WriteLine(max);