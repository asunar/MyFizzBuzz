using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
  class Program
  {
    static void Main(string[] args)
    {
      var wordNumberDictionary = new Dictionary<string, int>()
      {
        {"Fizz", 3},
        {"Buzz", 5},
      };
      var fizzBuzzList = FizzBuzzLib.FizzBuzzGenerator.Generate(wordNumberDictionary, Int32.MaxValue);
      //fizzBuzzList.ToList().ForEach(Console.WriteLine);

      foreach (var s in fizzBuzzList)
      {
        Console.WriteLine(s);
      }
        
      Console.ReadLine();
    }


  }
}