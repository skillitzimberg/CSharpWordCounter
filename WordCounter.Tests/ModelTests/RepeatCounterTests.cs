using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void RepeatCounterConstructor_CreatesInstanceOfReapeatCounter_RepeatCounter()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("word", "A sentence");
      Assert.AreEqual(typeof(RepeatCounter), newRepeatCounter.GetType());
    }

    [TestMethod]
    public void GetWordToFind_ReturnsWordToFind_WordToFind()
    {
      string wordToFind = "hello";
      string stringToSearch = "hello, world";
      RepeatCounter newRepeatCounter = new RepeatCounter(wordToFind, stringToSearch);

      string actualString = newRepeatCounter.GetWordToFind();

      Assert.AreEqual(wordToFind, actualString);
    }

    [TestMethod]
    public void GetStringToSearch_ReturnsTheStringToSearch_StringToSearch()
    {
      string wordToFind = "searched";
      string expectedStringToSearch = "This string is to be searched for WordToFind";

      RepeatCounter newRepeatCounter = new RepeatCounter(wordToFind, expectedStringToSearch);

      string actualStringToSearch = newRepeatCounter.GetStringToSearch();

      Assert.AreEqual(expectedStringToSearch, actualStringToSearch);
    }

    [TestMethod]
    public void CompareWordToFindWithStringToSearch_ConfirmWhetherStringsMatchOrNot_True()
    {
      Console.WriteLine("CompareWordToFindWithStringToSearch_ConfirmWhetherStringsMatchOrNot_True");
      string wordToFind = "w";
      string StringToSearch = "w";

      RepeatCounter newRepeatCounter = new RepeatCounter(wordToFind, StringToSearch);

      bool doStringsMatch = newRepeatCounter.CompareWordToFindWithStringToSearch();

      Assert.AreEqual(true, doStringsMatch);
    }

    [TestMethod]
    public void SearchStringToSearchForWordToFind_ConfirmWhetherStringToSearchContainsWordToFind_True()
    {
      string wordToFind = "a";
      string stringToSearch = "This is a cat.";

      RepeatCounter newRepeatCounter = new RepeatCounter(wordToFind, stringToSearch);

      bool doesStringToSearchContainWordToFind = newRepeatCounter.SearchStringToSearchForWordToFind();

      Assert.AreEqual(true, doesStringToSearchContainWordToFind);
    }

    [TestMethod]
    public void ReturnMatchingWords_ReturnAListOfMatchingWordsFound_ListOfFoundMatches()
    {
      string wordToFind = "an";
      string stringToSearch = "a cat that saw a rat and a dog had an anuerysm.";
      List<string> expectedList = new List<string> {"an"};

      RepeatCounter newRepeatCounter = new RepeatCounter(wordToFind, stringToSearch);

      List<string> actualList = newRepeatCounter.ReturnMatchingWords();

      CollectionAssert.AreEqual(expectedList, actualList);
    }

    [TestMethod]
    public void ReturnMatchingWords_ReturnAListOfMultipleMatchingWordsFound_ListOfFoundMatches()
    {
      string wordToFind = "happy";
      string stringToSearch = "I felt happy because I saw the others were happy and because I knew I should feel happy, but I wasn’t really happy.";
      List<string> expectedList = new List<string> {"happy", "happy", "happy", "happy"};

      RepeatCounter newRepeatCounter = new RepeatCounter(wordToFind, stringToSearch);

      List<string> actualList = newRepeatCounter.ReturnMatchingWords();

      CollectionAssert.AreEqual(expectedList, actualList);
    }

    [TestMethod]
    public void CountHowManyTimesTheWordWasFound_ReturnTheNumberOfTimesTheWordWasFound_Integer()
    {
      string wordToFind = "happy";
      string stringToSearch = "I felt happy because I saw the others were happy and because I knew I should feel happy, but I wasn’t really happy.";
      int expectedCount = 4;

      RepeatCounter newRepeatCounter = new RepeatCounter(wordToFind, stringToSearch);

      int actualCount = newRepeatCounter.CountHowManyTimesTheWordWasFound();

      Assert.AreEqual(expectedCount, actualCount);
    }
  }
}
