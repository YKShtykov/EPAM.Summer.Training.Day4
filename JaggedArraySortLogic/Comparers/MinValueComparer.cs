using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySortLogic
{
  /// <summary>
  /// Service class compares by minimum value
  /// </summary>
  class MinValueComparer : IComparer<int[]>
  {
    /// <summary>
    /// comparing by minimum value
    /// </summary>
    /// <param name="int[] x"></param>
    /// <param name="int[] y"></param>
    /// <returns></returns>
    public int Compare(int[] x, int[] y)
    {
      return x.Min().CompareTo(y.Min());
    }
  }
}
