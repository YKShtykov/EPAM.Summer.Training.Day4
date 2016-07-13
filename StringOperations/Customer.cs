using System;

namespace StringOperations
{
  /// <summary>
  /// Class consists customer data 
  /// </summary>
  public class Customer : IFormatProvider, ICustomFormatter, IFormattable
  {
    /// <summary>
    /// Customer name
    /// </summary>
    public string Name { get; private set; }
    /// <summary>
    /// Customer phone
    /// </summary>
    public string ContactPhone { get; private set; }
    /// <summary>
    /// Customer revenue
    /// </summary>
    public decimal Revenue { get; set; }

    public Customer(string name = "Jeffrey Rihter ", string contactPhone = "+1-(425)-555-0100 ", decimal revenue = 1000000)
    {
      Name = name;
      ContactPhone = contactPhone;
      Revenue = revenue;
    }

    /// <summary>
    /// IFormatProvider method
    /// </summary>
    /// <param name="formatType"></param>
    /// <returns></returns>
    public object GetFormat(Type formatType)
    {
      if (formatType == typeof(ICustomFormatter))
        return this;
      else
        return null;
    }

    /// <summary>
    /// ICustomFormatter method, returns various variants of customer string presentation
    /// </summary>
    /// <param name="format"></param>
    /// <param name="arg"></param>
    /// <param name="formatProvider"></param>
    /// <returns></returns>
    public string Format(string format, object arg, IFormatProvider formatProvider)
    {
      string result = string.Empty;

      switch (format.ToUpper())
      {
        case "N":
          result = Name;
          break;

        case "P":
          result = ContactPhone;
          break;

        case "R":
          result = Revenue.ToString();
          break;

        case "NR":
          result = Name + Revenue.ToString();
          break;

        default:
          result = Name + ContactPhone + Revenue.ToString();
          break;
      }
      return result;
    }

    /// <summary>
    /// IFormattable method, returns various variants of customer string presentation
    /// </summary>
    /// <param name="format"></param>
    /// <param name="formatProvider"></param>
    /// <returns></returns>
    public string ToString(string format, IFormatProvider formatProvider)
    {
      string result = string.Empty;

      switch (format.ToUpper())
      {
        case "N":
          result = Name;
          break;

        case "P":
          result = ContactPhone;
          break;

        case "R":
          result = Revenue.ToString();
          break;

        case "NR":
          result = Name + Revenue.ToString();
          break;

        default:
          result = Name + ContactPhone + Revenue.ToString();
          break;
      }
      return result;
    }
  }

  /// <summary>
  /// Class formatter for extending customer string presentation
  /// </summary>
  public class ExtendFormatter : IFormatProvider, ICustomFormatter
  {
    /// <summary>
    /// ICustomFormatter method, returns various variants of customer string presentation
    /// </summary>
    /// <param name="format"></param>
    /// <param name="arg"></param>
    /// <param name="formatProvider"></param>
    /// <returns></returns>
    public string Format(string format, object arg, IFormatProvider formatProvider)
    {
      switch (format)
      {
        case "A":
          return "this works!";
        default:
          return "this works defaultly";
      }
    }

    /// <summary>
    /// IFormatProvider method
    /// </summary>
    /// <param name="formatType"></param>
    /// <returns></returns>
    public object GetFormat(Type formatType)
    {
      if (formatType == typeof(ICustomFormatter))
        return this;
      else
        return null;
    }
  }
}
