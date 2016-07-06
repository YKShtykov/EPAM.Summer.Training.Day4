using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JaggedArraySortLogic;
using System.Diagnostics;

namespace JaggedArraySortLogicTests
{
  [TestClass]
  public class ArraySortTests
  {
    int[][] testedArr = new int[3][];

    [TestInitialize]
    public void Initialize()
    {
      testedArr[0] = new int[] { 2, 5, 10 };
      testedArr[1] = new int[] { -100, 100 };
      testedArr[2] = new int[] { 1000 };
    }
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
  }
}
