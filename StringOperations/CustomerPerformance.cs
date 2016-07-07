namespace StringOperations
{
  public static class CustomerPerformance
  {
    public static string CustomerRecord()
    {
      Customer jeffreyRihter = new Customer();
      return jeffreyRihter.Performance();
    }

    public static string FormatedCustomerRecord()
    {
      Customer jeffreyRihter = new Customer();
      return jeffreyRihter.FormatedPerformance();
    }
  }
}
