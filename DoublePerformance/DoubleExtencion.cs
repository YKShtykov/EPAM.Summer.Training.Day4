using System;
using System.Collections;
using System.Text;

namespace DoublePerformance
{
  /// <summary>
  /// Extencion class for double
  /// </summary>
  public static class DoubleExtencion
  {
    /// <summary>
    /// Extencion method returns string of binary code of value
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static string StringPerformance(this double value)
    {
      StringBuilder resultString = new StringBuilder();
      byte[] bytesArr = BitConverter.GetBytes(value);
      BitArray bitsArr = new BitArray(bytesArr);

      for (int i = 0; i < 64; i++)
      {
        if (bitsArr[i])
        {
          resultString.Insert(0, 1); 
        }
        else
        {
          resultString.Insert(0, 0);
        }
      }

      return resultString.ToString();
    }
  }
}
