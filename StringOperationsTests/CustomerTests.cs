using System;
using StringOperations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringOperationsTests
{
  /// <summary>
  /// Class testing Customer Performance
  /// </summary>
  [TestClass]
  public class CustomerTests
  {
    /// <summary>
    /// Test of full performance
    /// </summary>
    [TestMethod]
    public void CustomerPerformanceTest_DefaultCustomer_FullPerformance()
    {
      //Arrange 
      Customer customer = new Customer();
      string correctResult = "Customer Record: Jeffrey Rihter +1-(425)-555-0100 1000000";

      //Act
      string result = string.Format(new Customer(),"Customer Record: {0:G}",customer);

      //Assert
      Assert.AreEqual(result, correctResult);
    }

    /// <summary>
    /// Test of name performance
    /// </summary>
    [TestMethod]
    public void CustomerPerformanceTest_DefaultCustomer_NamePerformance()
    {
      //Arrange 
      Customer customer = new Customer();
      string correctResult = "Customer Record: Jeffrey Rihter ";

      //Act
      string result = string.Format(new Customer(),"Customer Record: {0:N}", customer);

      //Assert
      Assert.AreEqual(result, correctResult);
    }

    /// <summary>
    /// Test of phone performance
    /// </summary>
    [TestMethod]
    public void CustomerPerformanceTest_DefaultCustomer_PhonePerformance()
    {
      //Arrange 
      Customer customer = new Customer();
      string correctResult = "+1-(425)-555-0100 ";

      //Act
      string result = customer.ToString("P", customer);

      //Assert
      Assert.AreEqual(result, correctResult);
    }

    /// <summary>
    /// Test of extention method, returns Upper full performance
    /// </summary>
    //[TestMethod]
    public void CustomerPerformanceTest_DefaultCustomer_ToUpperPerformance()
    {
      //Arrange 
      Customer customer = new Customer();
      string correctResult = "Customer Record: Jeffrey Rihter +1-(425)-555-0100 1000000".ToUpper();

      //Act
      string result = string.Format("G", customer);

      //Assert
      Assert.AreEqual(result, correctResult);
    }

    /// <summary>
    /// Test of extention method, returns full performance without spaces
    /// </summary>
    [TestMethod]
    public void CustomerPerformanceTest_ExtendFormater_THisWorks()
    {
      //Arrange 
      Customer customer = new Customer();
      string correctResult = "this works!";

      //Act
      string result = string.Format(new ExtendFormatter(), "{0:A}", customer);

      //Assert
      Assert.AreEqual(result, correctResult);
    }
  }
}
