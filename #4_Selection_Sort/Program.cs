using static Sorting;
using static Infrastructure;;

// Классический вид:
// int[] array = CreateArray(10);
// Show(array);
// SortSelection(array);
// Show(array);

10.CreateArray(min: 10, max: 30)
  .Show(" , ") // исползуя separator в модуле можем задавать любой разделитель
  .SortSelection()
  .Show(" - ");

