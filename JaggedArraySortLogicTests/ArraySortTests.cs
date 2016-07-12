using Microsoft.VisualStudio.TestTools.UnitTesting;
using JaggedArraySortLogic;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System;

namespace JaggedArraySortLogicTests
{
  /// <summary>
  /// Class testing JaggedArraySortLogic
  /// </summary>
  [TestClass]
  public class ArraySortTests
  {
    int[][] testedArr = new int[3][];

    /// <summary>
    /// Initializing of initial Jagged array
    /// </summary>
    [TestInitialize]
    public void Initialize()
    {
      testedArr[0] = new int[] { 2, 5, 10 };
      testedArr[1] = new int[] { -100, 100 };
      testedArr[2] = new int[] { 1000 };
    }


    /// <summary>
    /// Summary sort testing
    /// </summary>
    [TestMethod]
    public void BubleSortSumTest()
    {
      //Arrange 
      SumValueSorting sortingObject = new SumValueSorting();
      int[][] resultSumArr = new int[3][];
      resultSumArr[1] = new int[] { 2, 5, 10 };
      resultSumArr[0] = new int[] { -100, 100 };
      resultSumArr[2] = new int[] { 1000 };

      //Act
      ArraySort.BubleSort(testedArr, sortingObject);

      //Assert
      Debug.WriteLine("{0}", testedArr[0][0]);
      Debug.WriteLine("{0}", testedArr[1][0]);
      Debug.WriteLine("{0}", testedArr[2][0]);
      for (int i = 0; i < testedArr.Length; i++)
      {
        CollectionAssert.AreEqual(testedArr[i], resultSumArr[i]);
      }
    }

    /// <summary>
    /// Maximum value sort testing
    /// </summary>
    [TestMethod]
    public void BubleSortMaxValueTest()
    {
      //Arrange
      MaxValueSorting sortingObject = new MaxValueSorting();
      int[][] resultSumArr = new int[3][];
      resultSumArr[0] = new int[] { 2, 5, 10 };
      resultSumArr[1] = new int[] { -100, 100 };
      resultSumArr[2] = new int[] { 1000 };

      //Act
      ArraySort.BubleSort(testedArr, sortingObject);

      //Assert
      Debug.WriteLine("{0}", testedArr[0][0]);
      Debug.WriteLine("{0}", testedArr[1][0]);
      Debug.WriteLine("{0}", testedArr[2][0]);
      for (int i = 0; i < testedArr.Length; i++)
      {
        CollectionAssert.AreEqual(testedArr[i], resultSumArr[i]);
      }
    }

    /// <summary>
    /// Minimum value sort testing
    /// </summary>
    [TestMethod]
    public void BubleSortMinValueTest()
    {
      //Arrange
      MinValueSorting sortingObject = new MinValueSorting();
      int[][] resultSumArr = new int[3][];
      resultSumArr[1] = new int[] { 2, 5, 10 };
      resultSumArr[0] = new int[] { -100, 100 };
      resultSumArr[2] = new int[] { 1000 };

      //Act
      ArraySort.BubleSort(testedArr, sortingObject);

      //Assert
      Debug.WriteLine("{0}", testedArr[0][0]);
      Debug.WriteLine("{0}", testedArr[1][0]);
      Debug.WriteLine("{0}", testedArr[2][0]);
      for (int i = 0; i < testedArr.Length; i++)
      {
        CollectionAssert.AreEqual(testedArr[i], resultSumArr[i]);
      }
    }

    [TestMethod]
    public void BubleSortAbsoluteValueTest()
    {
      //Arrange
      AbsoluteValueSorting sortingObject = new AbsoluteValueSorting();
      int[][] resultSumArr = new int[3][];
      resultSumArr[0] = new int[] { 2, 5, 10 };
      resultSumArr[1] = new int[] { -100, 100 };
      resultSumArr[2] = new int[] { 1000 };

      //Act
      ArraySort.BubleSort(testedArr, sortingObject);

      //Assert
      Debug.WriteLine("{0}", testedArr[0][0]);
      Debug.WriteLine("{0}", testedArr[1][0]);
      Debug.WriteLine("{0}", testedArr[2][0]);
      for (int i = 0; i < testedArr.Length; i++)
      {
        CollectionAssert.AreEqual(testedArr[i], resultSumArr[i]);
      }
    }

    public class MaxValueSorting : IComparer<int[]>
    {
      public int Compare(int[] x, int[] y)
      {
        return x.Max().CompareTo(y.Max());
      }
    }

    public class MaxValueSortingDescending : IComparer<int[]>
    {
      public int Compare(int[] x, int[] y)
      {
        return -x.Max().CompareTo(y.Max());
      }
    }

    public class MinValueSorting : IComparer<int[]>
    {
      public int Compare(int[] x, int[] y)
      {
        return x.Min().CompareTo(y.Min());
      }
    }

    public class MinValueSortingDescending : IComparer<int[]>
    {
      public int Compare(int[] x, int[] y)
      {
        return -x.Min().CompareTo(y.Min());
      }
    }

    public class SumValueSorting : IComparer<int[]>
    {
      public int Compare(int[] x, int[] y)
      {
        return x.Sum().CompareTo(y.Sum());
      }
    }

    public class SumValueSortingDescending : IComparer<int[]>
    {
      public int Compare(int[] x, int[] y)
      {
        return -x.Sum().CompareTo(y.Sum());
      }
    }

    public class AbsoluteValueSorting : IComparer<int[]>
    {
      public int Compare(int[] x, int[] y)
      {
        int lhs = (Math.Abs(x.Max()) >= Math.Abs(x.Min())) ? Math.Abs(x.Max()) : Math.Abs(x.Min());
        int rhs = (Math.Abs(y.Max()) >= Math.Abs(y.Min())) ? Math.Abs(y.Max()) : Math.Abs(y.Min());
        return lhs.CompareTo(rhs);
      }
    }
  }
}
