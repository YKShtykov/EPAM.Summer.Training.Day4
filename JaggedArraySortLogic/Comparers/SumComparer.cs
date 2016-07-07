using System.Collections.Generic;
using System.Linq;


namespace JaggedArraySortLogic
{
  /// <summary>
  /// Service class compares by summary of all row values
  /// </summary>
  class SumComparer : IComparer<int[]>
  {
    /// <summary>
    /// comparing by summary of all row values
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    public int Compare(int[] x, int[] y)
    {
      return x.Sum().CompareTo(y.Sum());
    }
  }
}
