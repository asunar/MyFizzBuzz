using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzzLibTests
{
    [TestFixture]
    public class FizzBuzzGeneratorTests
    {

      [Test]
      public void should_return_words_when_number_is_divisible_by_the_number_in_word_pair()
      {
        //Arrange
        var wordNumberDictionary = new Dictionary<string, int>()
        {
          {"Foo", 2},
          {"Fizz", 3},
          {"Buzz", 5},

        };
        //Act
        var numbers = FizzBuzzLib.FizzBuzzGenerator.Generate(wordNumberDictionary, 30).ToList();

        //Assert
        Assert.AreEqual(numbers.ToList()[1], "Foo");
        Assert.AreEqual(numbers.ToList()[2], "Fizz");
        Assert.AreEqual(numbers.ToList()[4], "Buzz");

        Assert.AreEqual(numbers.ToList()[29], "FooFizzBuzz");
      }
    }
}


// Customers asking for enhancements, ensuring the stability, add possible unit tests.

// Developers should be able to pass in their Number, Word pair (as many as they want)

// build script, git source control, finish, upload to Github. Email url to Rayne.
