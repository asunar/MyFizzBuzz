using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzLib
{
  public static class FizzBuzzGenerator
  {
    public static IEnumerable<string> Generate(Dictionary<string, int> wordNumberDictionary, int upperBound = 100)
    {
      var numbers = Enumerable.Range(1, upperBound);

      foreach (var number in numbers)
      {    
        yield return ProcessNumber(number, wordNumberDictionary);
      }
    }


    private static string ProcessNumber(int n, Dictionary<string, int> wordNumberDictionary)
    {
      var tempResult = "";

      foreach (var keyValuePair in wordNumberDictionary)
      {
        if (n % keyValuePair.Value == 0)
        {
          tempResult += keyValuePair.Key;
        }
      }

      var finalResult = tempResult == "" ? n.ToString() : tempResult;
      return finalResult;
    }
  }
}
