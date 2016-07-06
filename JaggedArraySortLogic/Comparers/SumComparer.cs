using System.Collections.Generic;
using System.Linq;


namespace JaggedArraySortLogic
{
  class SumComparer : IComparer<int[]>
  {
    public int Compare(int[] x, int[] y)
    {
      if (x == null && y == null)
      {
        return 0;
      }

      if (x == null)
      {
        return -1;
      }

      if (y == null)
      {
        return 1;
      }

      return x.Sum().CompareTo(y.Sum());
    }
  }
}
