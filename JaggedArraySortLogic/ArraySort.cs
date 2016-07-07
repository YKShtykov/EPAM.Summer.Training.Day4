using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace JaggedArraySortLogic
{
  /// <summary>
  /// Class sortint jagged arrays by various variants
  /// </summary>
  public class ArraySort
  {
    /// <summary>
    /// BubleSort method sorts jagged arrays by various variants
    /// </summary>
    /// <param name="int[][] arr"></param>
    /// <param name="SortVariant option"></param>
    /// <param name="bool descending"></param>
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
          if (arr[j]!=null&& arr[j - 1]!=null)
          {
            if (arrComparer.Compare(arr[j], arr[j - 1]) == -1)
            {
              Swap(ref arr[j], ref arr[j - 1]);
            }
          }
          else
          {
            if (arr[j] == null)
            {
              Swap(ref arr[j], ref arr[j - 1]);
            }
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
