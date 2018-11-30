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
    public void Get_wordToFind_ReturnsWordToFind_WordToFind()
    {
      string wordToFind = "hello";
      string stringToSearch = "hello, world";
      RepeatCounter newRepeatCounter = new RepeatCounter(wordToFind, stringToSearch);

      string actualString = newRepeatCounter.Get_wordToFind();

      Assert.AreEqual(wordToFind, actualString);
    }

    [TestMethod]
    public void Get_stringToSearch_ReturnsTheStringToSearch_StringToSearch()
    {
      string wordToFind = "searched";
      string expectedStringToSearch = "This string is to be searched for WordToFind";

      RepeatCounter newRepeatCounter = new RepeatCounter(wordToFind, expectedStringToSearch);

      string actualStringToSearch = newRepeatCounter.Get_stringToSearch();

      Assert.AreEqual(expectedStringToSearch, actualStringToSearch);
    }

    [TestMethod]
    public void _wordToFindMatches_ConfirmWhetherStringsMatchOrNot_True()
    {
      string wordToFind = "w";
      string stringToSearch = "w";

      RepeatCounter newRepeatCounter = new RepeatCounter(wordToFind, stringToSearch);

      bool doStringsMatch = newRepeatCounter._wordToFindMatches(stringToSearch);

      Assert.AreEqual(true, doStringsMatch);
    }

    [TestMethod]
    public void FindMatchingWords_ReturnAListOfMatchingWordsFound_ListOfFoundMatches()
    {
      string wordToFind = "an";
      string stringToSearch = "a cat that saw a rat and a dog had an anuerysm.";
      List<string> expectedList = new List<string> {"an"};

      RepeatCounter newRepeatCounter = new RepeatCounter(wordToFind, stringToSearch);

      List<string> actualList = newRepeatCounter.FindMatchingWords();

      CollectionAssert.AreEqual(expectedList, actualList);
    }

    [TestMethod]
    public void FindMatchingWords_ReturnAListOfMultipleMatchingWordsFound_ListOfFoundMatches()
    {
      string wordToFind = "happy";
      string stringToSearch = "I felt happy because I saw the others were happy and because I knew I should feel happy, but I wasn’t really happy.";
      List<string> expectedList = new List<string> {"happy", "happy", "happy", "happy"};

      RepeatCounter newRepeatCounter = new RepeatCounter(wordToFind, stringToSearch);

      List<string> actualList = newRepeatCounter.FindMatchingWords();

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
