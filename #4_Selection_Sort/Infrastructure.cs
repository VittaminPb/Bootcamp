public static class Infrastructure
{
    /// <summary>
    /// Метод создания и заполнерия массива
    /// </summary>
    /// <param name="size">размер нового массива</param>
    /// <param name="min">нижняя граница заполнения</param>
    /// <param name="max">верхняя граница заполнения</param>
    /// <returns>Новый массив</returns>
    public static int[] CreateArray(this int size, int min = 0, int max = 10)
    {
        return Enumerable.Range(1, size)
                         .Select(item => Random.Shared.Next(min, max))
                         .ToArray();
    }

    /// <summary>
    /// Вывод массива в консоль
    /// </summary>
    /// <param name="array">Исходный массив</param>
    /// <param name="separator">Символ-разделитель элементов массива</param>
    /// <returns>Исходный массив</returns>
    public static int[] Show(this int[] array, string separator = ", ")
    {
        string output = String.Join(separator, array);
        Console.WriteLine($"[{output}]");
        return array;
    }
}
