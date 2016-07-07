using System.Globalization;

namespace StringOperations
{
  static class CustomerExtension
  {
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

        case FormatedPerformanceVariant.UnderScoreInsteadSpace:
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
