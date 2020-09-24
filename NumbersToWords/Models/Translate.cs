using System;
using System.Collections.Generic;

namespace NumbersToWords.Models
{
  public class Translate
  {

    public string OneThruNineteen (int onesInput)
    {
      Dictionary<int, string> OneThruNineteenValues = new Dictionary<int, string>() { {0, "zero"}, {1, "one"}, {2, "two"}, {3, "three"}, {4, "four"}, {5, "five"}, {6, "six"}, {7, "seven"}, {8, "eight"}, {9, "nine"}, {10, "ten"}, {11, "eleven"},  {12, "twelve"},  {13, "thirteen"},  {14, "fourteen"},  {15, "fifteen"},  {16, "sixteen"},  {17, "seventeen"},  {18, "eighteen"},  {19, "nineteen"} };

      string output = OneThruNineteenValues[onesInput];
      return output;
    }
    public string TensAfterNineteen (string tensInput)
    {
      Dictionary<string, string> twentyThruNinetyNine = new Dictionary<string, string>() { {"2", "twenty"}, {"3", "thirty"}, {"4", "forty"}, {"5", "fifty"}, {"6", "sixty"}, {"7", "seventy"}, {"8", "eighty"}, {"9", "ninety"} };
      
      string tensNumber = tensInput.Substring(0,1);
      string output = twentyThruNinetyNine[tensNumber];
      return output; 

    }
    public string OneHundreds (string hundredsInput)
    {
       Dictionary<string, string> oneThruNineHundred = new Dictionary<string, string>() { {"1", "one"}, {"2", "two"}, {"3", "three"}, {"4", "four"}, {"5", "five"}, {"6", "six"}, {"7", "seven"}, {"8", "eight"}, {"9", "nine"} };
      
      string hundreds = hundredsInput.Substring(0,1);
      string output = oneThruNineHundred[hundreds];
      return output + " hundred";
    }
  }
}