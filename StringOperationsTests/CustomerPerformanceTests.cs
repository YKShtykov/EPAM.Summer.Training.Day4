using System;
using StringOperations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringOperationsTests
{
  [TestClass]
  public class CustomerPerformanceTests
  {
    [TestMethod]
    public void CustomerPerformanceTest_DefaultCustomer_FullPerformance()
    {
      //Arrange 
      Customer customer = new Customer();
      string correctResult = "Customer Record: Jeffrey Rihter +1-(425)-555-0100 1000000";

      //Act
      string result = customer.Performance();

      //Assert
      Assert.AreEqual(result, correctResult);
    }

    [TestMethod]
    public void CustomerPerformanceTest_DefaultCustomer_NamePerformance()
    {
      //Arrange 
      Customer customer = new Customer();
      string correctResult = "Customer Record: Jeffrey Rihter ";

      //Act
      string result = customer.Performance(PerformanceVariant.Name);

      //Assert
      Assert.AreEqual(result, correctResult);
    }

    [TestMethod]
    public void CustomerPerformanceTest_DefaultCustomer_PhonePerformance()
    {
      //Arrange 
      Customer customer = new Customer();
      string correctResult = "Customer Record: +1-(425)-555-0100 ";

      //Act
      string result = customer.Performance(PerformanceVariant.PhoneNumber);

      //Assert
      Assert.AreEqual(result, correctResult);
    }

    [TestMethod]
    public void CustomerPerformanceTest_DefaultCustomer_ToUpperPerformance()
    {
      //Arrange 
      Customer customer = new Customer();
      string correctResult = "Customer Record: Jeffrey Rihter +1-(425)-555-0100 1000000".ToUpper();

      //Act
      string result = customer.FormatedPerformance();

      //Assert
      Assert.AreEqual(result, correctResult);
    }

    [TestMethod]
    public void CustomerPerformanceTest_DefaultCustomer_UnderScoreInsteadSpacePerformance()
    {
      //Arrange 
      Customer customer = new Customer();
      string correctResult = "Customer_Record:_Jeffrey_Rihter_+1-(425)-555-0100_1000000";

      //Act
      string result = customer.FormatedPerformance(FormatedPerformanceVariant.UnderscoreInsteadSpace);

      //Assert
      Assert.AreEqual(result, correctResult);
    }

    [TestMethod]
    public void CustomerPerformanceTest_DefaultCustomer_WithoutBracersPerformance()
    {
      //Arrange 
      Customer customer = new Customer();
      string correctResult = "Customer Record: Jeffrey Rihter +1-425-555-0100 1000000";

      //Act
      string result = customer.FormatedPerformance(FormatedPerformanceVariant.RemoveBracers);

      //Assert
      Assert.AreEqual(result, correctResult);
    }
  }
}
