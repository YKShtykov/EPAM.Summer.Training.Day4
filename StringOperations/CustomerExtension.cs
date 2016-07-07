using System.Globalization;

namespace StringOperations
{
  /// <summary>
  /// Exctention class
  /// </summary>
  public static class CustomerExtension
  {
    /// <summary>
    /// Retuns formated customer record in various variants
    /// </summary>
    /// <param name="Customer customer"></param>
    /// <param name="FormatedPerformanceVariant option"></param>
    /// <returns>Formated customer record</returns>
    public static string FormatedPerformance(this Customer customer, FormatedPerformanceVariant option = FormatedPerformanceVariant.ToUpper)
    {
      string result = string.Format(CultureInfo.InvariantCulture, customer.Performance());

      switch (option)
      {
        case FormatedPerformanceVariant.ToLower:
          result.ToLower();
          break;

        case FormatedPerformanceVariant.FixedLength:
          string[] temp = result.Split();
          foreach (string s in temp)
          {
            s.PadRight(20, ' ');
          }
          result = string.Join(string.Empty, temp);
          break;

        case FormatedPerformanceVariant.RemoveBracers:
          result = result.Replace("(", string.Empty);
          result = result.Replace(")", string.Empty);
          break;

        case FormatedPerformanceVariant.UnderscoreInsteadSpace:
          result = result.Replace(" ", "_");
          break;

        default:
          result = result.ToUpper();
          break;
      }
      return result;
    }
  }
}
