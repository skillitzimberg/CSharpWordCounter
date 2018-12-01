using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class CounterTest
  {
    [TestMethod]
    public void Get_wordToFind_ReturnsWordToFind_String()
    {
      string wordToFind = "a";
      string stringToSearch = "b";
      Counter newCounter = new Counter(wordToFind, stringToSearch);

      string actualString = newCounter.Get_wordToFind();

      Assert.AreEqual(wordToFind, actualString);
    }

    [TestMethod]
    public void Get_stringToSearch_ReturnsStringToSearch_String()
    {
      string wordToFind = "a";
      string expectedStringToSearch = "b";

      Counter newCounter = new Counter(wordToFind, expectedStringToSearch);

      string actualStringToSearch = newCounter.Get_stringToSearch();

      Assert.AreEqual(expectedStringToSearch, actualStringToSearch);
    }

    [TestMethod]
    public void GetandSet_matchCounth_ReturnsMatchCount_Int()
    {
      string wordToFind = "a";
      string stringToSearch = "b";
      int expectedMatchCount = 3;

      Counter newCounter = new Counter(wordToFind, stringToSearch);
      newCounter.Set_matchCount(expectedMatchCount);
      int actualMatchCount = newCounter.Get_matchCount();

      Assert.AreEqual(expectedMatchCount, actualMatchCount);
    }

    [TestMethod]
    public void _wordToFindMatches_ConfirmWhetherStringsMatchOrNot_False()
    {
      string wordToFind = "a";
      string stringToSearch = "banana";

      Counter newCounter = new Counter(wordToFind, stringToSearch);

      bool doStringsMatch = newCounter._wordToFindMatches(stringToSearch);

      Assert.AreEqual(false, doStringsMatch);
    }


    // [TestMethod]
    // public void Get_matchCount_ReturnsNumberOfWordInstances_Int()
    // {
    //   string wordToFind = "happy";
    //   string expectedStringToSearch = "I felt happy because I saw the others were happy and because I knew I should feel happy, but I wasn’t really happy.";
    //   int expectedCount = 4;
    //
    //   Counter newCounter = new Counter(wordToFind, expectedStringToSearch);
    //
    //   int count = newCounter.CountHowManyTimesTheWordWasFound();
    //   newCounter.Set_matchCount(count);
    //   int actualCount = newCounter.Get_matchCount();
    //
    //   // Console.WriteLine("CounterTests: " + actualCount);
    //
    //   Assert.AreEqual(expectedCount, actualCount);
    // }

    [TestMethod]
    public void FindMatchingWords_ReturnAListOfMatchingWordsFound_ListOfFoundMatches()
    {
      string wordToFind = "banana";
      string stringToSearch = "one banana";
      List<string> expectedList = new List<string> {"banana"};

      Counter newCounter = new Counter(wordToFind, stringToSearch);

      List<string> actualList = newCounter.FindMatchingWords();

      CollectionAssert.AreEqual(expectedList, actualList);
    }

    [TestMethod]
    public void CountMatches_ReturnTheNumberOfTimesTheWordWasFound_Int()
    {
      string wordToFind = "banana";
      string stringToSearch = "banana cabana bananas banana annabanana another banana";
      int expectedCount = 3;

      Counter newCounter = new Counter(wordToFind, stringToSearch);


      int actualCount = newCounter.CountMatches();

      Assert.AreEqual(expectedCount, actualCount);
    }

    [TestMethod]
    public void Counter_MatchesWordsCaseInsensitive_Int()
    {
      string wordToFind = "bAnana";
      string stringToSearch = "Banana cabana bananas baNana annabanana another bananA";
      int expectedCount = 3;

      Counter newCounter = new Counter(wordToFind, stringToSearch);

      int actualCount = newCounter.CountMatches();

      Assert.AreEqual(expectedCount, actualCount);
    }

    [TestMethod]
    public void RemovePunctuation_RemovesPunctuation_String()
    {
      string wordToFind = "happy";
      string stringToSearch = ".,happy.";
      string expectedString = "happy";

      Counter newCounter = new Counter(wordToFind, stringToSearch);

      string actualString = newCounter.RemovePunctuation(stringToSearch);

      Assert.AreEqual(expectedString, actualString);
    }

    [TestMethod]
    public void Counter_IgnoresPunctuation_Int()
    {
      string wordToFind = "happy";
      string stringToSearch = "I felt happy because I saw the others were .happy and because I knew I should feel happy,. but I wasn’t really happy.";
      List<string> expectedList = new List<string> {"happy", "happy", "happy", "happy"};

      Counter newCounter = new Counter(wordToFind, stringToSearch);

      List<string> actualList = newCounter.FindMatchingWords();

      CollectionAssert.AreEqual(expectedList, actualList);
    }

  }
}
