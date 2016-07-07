using System.Globalization;

namespace StringOperations
{
  public class Customer
  {
    public string Name { get; private set; }
    public string ContactPhone { get; private set; }
    public decimal Revenue { get; set; }

    public Customer(string name = "Jeffrey Rihter ", string contactPhone = "+1-(425)-555-0100 ", decimal revenue = 1000000)
    {
      Name = name;
      ContactPhone = contactPhone;
      Revenue = revenue;
    }

    public string Performance(PerformanceVariant option = PerformanceVariant.Full)
    {
      CultureInfo culture = CultureInfo.InvariantCulture;
      string customerRecord = "Customer Record: ";
      string result;
      switch (option)
      {
        case PerformanceVariant.Short:
          result = Name + ContactPhone;
          break;

        case PerformanceVariant.Name:
          result = Name;
          break;

        case PerformanceVariant.Revenue:
          result = string.Format(culture, "{0}", Revenue);
          break;

        case PerformanceVariant.PhoneNumber:
          result = ContactPhone;
          break;

        default:
          result = Name + ContactPhone + string.Format(culture, "{0}", Revenue);
          break;
      }
      return string.Format(culture, customerRecord + result);
    }
  }
}
