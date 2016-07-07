namespace StringOperations
{
  public static class CustomerPerformance
  {
    public static string CustomerRecord(Customer customer)
    {
      return customer.Performance();
    }

    public static string FormatedCustomerRecord(Customer customer)
    {
      return customer.FormatedPerformance();
    }
  }
}
