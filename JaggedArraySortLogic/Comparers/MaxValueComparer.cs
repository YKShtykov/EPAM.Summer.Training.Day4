using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySortLogic
{
  /// <summary>
  /// Service class compares by maximum value
  /// </summary>
  class MaxValueComparer : IComparer<int[]>
  {
    /// <summary>
    /// comparing by minimum value
    /// </summary>
    /// <param name="int[] x"></param>
    /// <param name="int[] y"></param>
    /// <returns></returns>
    public int Compare(int[] x, int[] y)
    {
      return x.Max().CompareTo(y.Max());
    }
  }
}
