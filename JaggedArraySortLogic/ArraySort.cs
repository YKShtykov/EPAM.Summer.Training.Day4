using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace JaggedArraySortLogic
{
  public class ArraySort
  {
    public static void BubleSort(int[][] arr, SortVariant option = SortVariant.Sum, bool descending = false)
    {
      int length = arr.Length;
      IComparer<int[]> arrComparer;
      switch (option)
      {
        case SortVariant.MaxValue:
          arrComparer = new MaxValueComparer();
          break;
        case SortVariant.MinVavue:
          arrComparer = new MinValueComparer();
          break;
        default:
          arrComparer = new SumComparer();
          break;
      }

      for (int k = 0; k < length; k++)
      {
        for (int j = 1; j < length - k; j++)
        {
          if (arrComparer.Compare(arr[j], arr[j - 1]) == -1)
          {
            Swap(ref arr[j], ref arr[j - 1]);
          }
        }
      }

      if (descending)
      {
        Array.Reverse(arr);
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
