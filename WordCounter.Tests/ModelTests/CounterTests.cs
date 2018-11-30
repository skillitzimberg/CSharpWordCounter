using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class CounterTest
  {
    [TestMethod]
    public void Get_wordToFind_ReturnsWordToFind_WordToFind()
    {
      string wordToFind = "hello";
      string stringToSearch = "hello, world";
      Counter newCounter = new Counter(wordToFind, stringToSearch);

      string actualString = newCounter.Get_wordToFind();

      Assert.AreEqual(wordToFind, actualString);
    }

    [TestMethod]
    public void Get_stringToSearch_ReturnsTheStringToSearch_StringToSearch()
    {
      string wordToFind = "searched";
      string expectedStringToSearch = "This string is to be searched for WordToFind";

      Counter newCounter = new Counter(wordToFind, expectedStringToSearch);

      string actualStringToSearch = newCounter.Get_stringToSearch();

      Assert.AreEqual(expectedStringToSearch, actualStringToSearch);
    }

    [TestMethod]
    public void Get_matchCount_ReturnsNumberOfWordInstances_Int()
    {
      string wordToFind = "happy";
      string expectedStringToSearch = "I felt happy because I saw the others were happy and because I knew I should feel happy, but I wasn’t really happy.";
      int expectedCount = 2;

      Counter newCounter = new Counter(wordToFind, expectedStringToSearch);

      int actualCount = newCounter.Get_matchCount();

      Assert.AreEqual(expectedCount, actualCount);
    }

    [TestMethod]
    public void _wordToFindMatches_ConfirmWhetherStringsMatchOrNot_True()
    {
      string wordToFind = "w";
      string stringToSearch = "w";

      Counter newCounter = new Counter(wordToFind, stringToSearch);

      bool doStringsMatch = newCounter._wordToFindMatches(stringToSearch);

      Assert.AreEqual(true, doStringsMatch);
    }

    [TestMethod]
    public void FindMatchingWords_ReturnAListOfMatchingWordsFound_ListOfFoundMatches()
    {
      string wordToFind = "an";
      string stringToSearch = "a cat that saw a rat and a dog had an anuerysm.";
      List<string> expectedList = new List<string> {"an"};

      Counter newCounter = new Counter(wordToFind, stringToSearch);

      List<string> actualList = newCounter.FindMatchingWords();

      CollectionAssert.AreEqual(expectedList, actualList);
    }

    [TestMethod]
    public void FindMatchingWords_ReturnAListOfMultipleMatchingWordsFound_ListOfFoundMatches()
    {
      string wordToFind = "happy";
      string stringToSearch = "I felt happy because I saw the others were happy and because I knew I should feel happy, but I wasn’t really happy.";
      List<string> expectedList = new List<string> {"happy", "happy", "happy", "happy"};

      Counter newCounter = new Counter(wordToFind, stringToSearch);

      List<string> actualList = newCounter.FindMatchingWords();

      CollectionAssert.AreEqual(expectedList, actualList);
    }

    [TestMethod]
    public void CountHowManyTimesTheWordWasFound_ReturnTheNumberOfTimesTheWordWasFound_Integer()
    {
      string wordToFind = "happy";
      string stringToSearch = "I felt happy because I saw the others were happy and because I knew I should feel happy, but I wasn’t really happy.";
      int expectedCount = 4;

      Counter newCounter = new Counter(wordToFind, stringToSearch);

      int actualCount = newCounter.CountHowManyTimesTheWordWasFound();

      Assert.AreEqual(expectedCount, actualCount);
    }

    [TestMethod]
    public void _wordToFindMatches_MatchesWordsCaseInsensitive_True()
    {
      string wordToFind = "w";
      string stringToSearch = "W";

      Counter newCounter = new Counter(wordToFind, stringToSearch);

      bool doStringsMatch = newCounter._wordToFindMatches(stringToSearch);

      Assert.AreEqual(true, doStringsMatch);
    }
  }
}