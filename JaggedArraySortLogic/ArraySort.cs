using System;
using System.Collections;
using System.Collections.Generic;

namespace JaggedArraySortLogic
{
  /// <summary>
  /// Class sortint jagged arrays by various variants
  /// </summary>
  public class ArraySort
  {
    public delegate int Comparer(int[] lhs, int[] rhs);
    public static void BubleSort(int[][] arr, IComparer<int[]> sortingObject)
    {
      Comparer comparer = sortingObject.Compare;
      Sort(arr, comparer);
    }

    private static void Sort(int[][] arr, Comparer comparer)
    {
      bool sorted = false;

      while (!sorted)
      {
        sorted = true;
        for (int i = 0; i < arr.Length - 1; i++)
        {
          if (comparer(arr[i], arr[i + 1]) == 1)
          {
            Swap(ref arr[i], ref arr[i + 1]);
            sorted = false;
          }
        }
      }
    }

    private static void Swap(ref int[] a, ref int[] b)
    {
      int[] temp = a;
      a = b;
      b = temp;
    }
  }
}
