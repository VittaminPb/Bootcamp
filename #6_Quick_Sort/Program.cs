using System;
namespace ConsoleApp3
/*
                              v - pivot
1. arr = {1, 0, -6, 3, -1, 5, 2}
2. pivot = arr[6] (опорный элемент) => [1, 0, -6, -1] 2 [3, 5]
3. Вызвать шаги 1-2 для подмассива слева от pivot и справа от pivot
*/
{
    partial class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, -5, 2, 3, 5, 9, -1, 7 };
            QuickSort(arr, 0, arr.Length - 1);
            Console.Write($"Отсортированный массив {string.Join(", ", arr)}");
        }

    }
}