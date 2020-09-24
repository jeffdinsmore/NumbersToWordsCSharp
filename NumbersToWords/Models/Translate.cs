using System;
using System.Collections.Generic;

namespace NumbersToWords.Models
{
  public class Translate
  {

    public string Ones (int number)
    {
      Dictionary<int, string> OnesValues = new Dictionary<int, string>() { {0, "zero"}, {1, "one"}, {2, "two"}, {3, "three"}, {4, "four"}, {5, "five"}, {6, "six"}, {7, "seven"}, {8, "eight"}, {9, "nine"} };

      string output = OnesValues[number];
      return output;
    }

  }
}