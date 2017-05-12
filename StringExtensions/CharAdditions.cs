using System;

namespace Jockusch.Common
{
  public static class CharAdditions
  {
    /// <summary>Does not include decimal point or minus
    /// sign. See also IsNumeric.</summary>
    public static bool IsDigit (this char c) {
      bool r = (c >= '0' && c <= '9');
      return r;
    }
    /// <summary>Includes decimal point, minus sign, and comma.</summary>
    public static bool IsNumeric (this char c) {
      bool r = false;
      if (c.IsDigit ()) {
        r = true;
      }
      if (c == '.' || c == '-' || c == ',') {
        r = true;
      }
      return r;
    }
    public static bool? IsVowel (this char c) {
      switch (c) {
      case 'a':
      case 'e':
      case 'i':
      case 'o':
      case 'u':
        return true;
      case 'y':
      case 'w':
        return null;
      default:
        return false;
      }
    }
  }
}

