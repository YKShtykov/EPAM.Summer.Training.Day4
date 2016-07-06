using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySortLogic
{
  class MinValueComparer : IComparer<int[]>
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

      return x.Min().CompareTo(y.Min());
    }
  }
}
