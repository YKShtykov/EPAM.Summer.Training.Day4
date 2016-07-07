using DoublePerformance;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DoublePerformanceTests
{
  /// <summary>
  /// Tests Extencion class DoublePerformance
  /// </summary>
  [TestClass]
  public class DoublePerformanceTests
  {
    /// <summary>
    /// Input minus value
    /// </summary>
    [TestMethod]
    public void StringPerformanceTest_Minus100()
    {
      //Arrange
      double testedDouble = -100;
      string correctResult = "1100000001011001000000000000000000000000000000000000000000000000";
      ;
      string result;

      //Act
      result = testedDouble.StringPerformance();

      //Assert
      Assert.AreEqual(correctResult, result);
    }

    /// <summary>
    /// Input large value
    /// </summary>
    [TestMethod]
    public void StringPerformanceTest_1234567890()
    {
      //Arrange
      double testedDouble = 1234567890;
      string correctResult = "0100000111010010011001011000000010110100100000000000000000000000";
      ;
      string result;

      //Act
      result = testedDouble.StringPerformance();

      //Assert
      Assert.AreEqual(correctResult, result);
    }

    /// <summary>
    /// Input maximum value of double
    /// </summary>
    [TestMethod]
    public void StringPerformanceTest_MaxValue()
    {
      //Arrange
      double testedDouble = double.MaxValue;
      string correctResult = "0111111111101111111111111111111111111111111111111111111111111111";
      ;
      string result;

      //Act
      result = testedDouble.StringPerformance();

      //Assert
      Assert.AreEqual(correctResult, result);
    }

    /// <summary>
    /// Input NaN
    /// </summary>
    [TestMethod]
    public void StringPerformanceTest_NaN()
    {
      //Arrange
      double testedDouble = double.NaN;
      string correctResult = "1111111111111000000000000000000000000000000000000000000000000000";
      ;
      string result;

      //Act
      result = testedDouble.StringPerformance();

      //Assert
      Assert.AreEqual(correctResult, result);
    }
  }
}
