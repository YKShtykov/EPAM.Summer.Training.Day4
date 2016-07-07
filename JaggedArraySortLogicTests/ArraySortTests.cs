using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JaggedArraySortLogic;
using System.Diagnostics;

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
      int[][] resultSumArr = new int[3][];
      resultSumArr[1] = new int[] { 2, 5, 10 };
      resultSumArr[0] = new int[] { -100, 100 };
      resultSumArr[2] = new int[] { 1000 };

      //Act
      ArraySort.BubleSort(testedArr);

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
      int[][] resultSumArr = new int[3][];
      resultSumArr[0] = new int[] { 2, 5, 10 };
      resultSumArr[1] = new int[] { -100, 100 };
      resultSumArr[2] = new int[] { 1000 };

      //Act
      ArraySort.BubleSort(testedArr,option: SortVariant.MaxValue);

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
      int[][] resultSumArr = new int[3][];
      resultSumArr[1] = new int[] { 2, 5, 10 };
      resultSumArr[0] = new int[] { -100, 100 };
      resultSumArr[2] = new int[] { 1000 };

      //Act
      ArraySort.BubleSort(testedArr, option: SortVariant.MinVavue);

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
    /// Minimum value sort testing with null
    /// </summary>
    [TestMethod]
    public void BubleSortMinValueTest_OneRowISNull()
    {
      //Arrange
      testedArr[0] = null;

      int[][] resultSumArr = new int[3][];
      resultSumArr[0] = null;
      resultSumArr[1] = new int[] { -100, 100 };
      resultSumArr[2] = new int[] { 1000 };

      //Act
      ArraySort.BubleSort(testedArr, option: SortVariant.MinVavue);

      //Assert
      for (int i = 0; i < testedArr.Length; i++)
      {
        CollectionAssert.AreEqual(testedArr[i], resultSumArr[i]);
      }
    }
  }
}
