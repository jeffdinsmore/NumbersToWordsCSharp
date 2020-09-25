using System;
using System.Collections.Generic;

namespace NumbersToWords.Models
{
  public class Translate
  {

    public string OneThruNineteen (string onesInput)
    {
      Dictionary<int, string> OneThruNineteenValues = new Dictionary<int, string>() { {0, "zero"}, {1, "one"}, {2, "two"}, {3, "three"}, {4, "four"}, {5, "five"}, {6, "six"}, {7, "seven"}, {8, "eight"}, {9, "nine"}, {10, "ten"}, {11, "eleven"},  {12, "twelve"},  {13, "thirteen"},  {14, "fourteen"},  {15, "fifteen"},  {16, "sixteen"},  {17, "seventeen"},  {18, "eighteen"},  {19, "nineteen"} };
      
      if (onesInput.Substring((onesInput.Length-1),1) == "0" && onesInput.Length > 1)
      {
        string output = "";
        return output;
      }
      else 
      {
        string ones = onesInput.Substring((onesInput.Length-1),1); 
        int onesInteger = int.Parse(ones);
        string output = OneThruNineteenValues[onesInteger];
        return output;
      }
      
    }
    public string TensAfterNineteen (string tensInput)
    {
      Dictionary<string, string> twentyThruNinetyNine = new Dictionary<string, string>() { {"0", ""}, {"1", ""}, {"2", "twenty"}, {"3", "thirty"}, {"4", "forty"}, {"5", "fifty"}, {"6", "sixty"}, {"7", "seventy"}, {"8", "eighty"}, {"9", "ninety"} };
      
        string tens = tensInput.Substring((tensInput.Length-2),1);
        string output = twentyThruNinetyNine[tens];
        return output;
      }
      
    
    public string OneHundreds (string hundredsInput)
    {
       Dictionary<string, string> oneThruNineHundred = new Dictionary<string, string>() { {"0", ""}, {"1", "one"}, {"2", "two"}, {"3", "three"}, {"4", "four"}, {"5", "five"}, {"6", "six"}, {"7", "seven"}, {"8", "eight"}, {"9", "nine"} };
      
      string hundreds = hundredsInput.Substring((hundredsInput.Length-3),1);
      string output = oneThruNineHundred[hundreds];
      return output;
    }

    public string OneThousands (string thousandsInput)
    {
       Dictionary<string, string> onesOfThousands = new Dictionary<string, string>() { {"0", ""}, {"1", "one"}, {"2", "two"}, {"3", "three"}, {"4", "four"}, {"5", "five"}, {"6", "six"}, {"7", "seven"}, {"8", "eight"}, {"9", "nine"} };
      
      Dictionary<string, string> TensOfThousands = new Dictionary<string, string>() { {"0", ""}, {"1", "ten"}, {"11", "eleven"},  {"12", "twelve"},  {"13", "thirteen"},  {"14", "fourteen"},  {"15", "fifteen"},  {"16", "sixteen"},  {"17", "seventeen"},  {"18", "eighteen"},  {"19", "nineteen"}, {"2", "twenty"}, {"3", "thirty"}, {"4", "forty"}, {"5", "fifty"}, {"6", "sixty"}, {"7", "seventy"}, {"8", "eighty"}, {"9", "ninety"} };
       
      if (thousandsInput.Length == 4)
      {
        string thousands = thousandsInput.Substring((thousandsInput.Length-4),1);
        string output = onesOfThousands[thousands];
        return output + " thousand";
      }
      else if (thousandsInput.Length == 5)
      {
        if (int.Parse(thousandsInput.Substring((thousandsInput.Length-5),2)) <= 19 && int.Parse(thousandsInput.Substring((thousandsInput.Length-5),2)) >= 10)
        {
          string tenInThousands = thousandsInput.Substring((thousandsInput.Length-5),2);
          string output = TensOfThousands[tenInThousands];
          return output + " thousand";
        }
        else
        {
          string oneInThousands = thousandsInput.Substring((thousandsInput.Length-4),1);
          string tenInThousands = thousandsInput.Substring((thousandsInput.Length-5),1);
          string output = TensOfThousands[tenInThousands] + "-" + onesOfThousands[oneInThousands];
          return output + " thousand";
        }
        
      }
      else if (thousandsInput.Length == 6)
      {
        string oneInThousands = thousandsInput.Substring((thousandsInput.Length-4),1);
        string tenInThousands = thousandsInput.Substring((thousandsInput.Length-5),1);
        string hundredInThousands = thousandsInput.Substring((thousandsInput.Length-6),1);
        string output = onesOfThousands[hundredInThousands] + " hundred " + TensOfThousands[tenInThousands] + "-" + onesOfThousands[oneInThousands];
        return output + " thousand";
      }
      else
      {
        string output = "";
        return output;
      }

      
    }
  }
}