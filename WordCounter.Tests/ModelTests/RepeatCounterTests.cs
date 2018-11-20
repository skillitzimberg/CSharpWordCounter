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
            string expectedWordToFind = "hello";
            string stringToSearch = "hello, world";
            RepeatCounter newRepeatCounter = new RepeatCounter(expectedWordToFind, stringToSearch);

            string actualWordToFind = newRepeatCounter.GetWordToFind();

            Assert.AreEqual(expectedWordToFind, actualWordToFind);
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
        public void CompareWordToFindWithWordFound_ConfirmThatSingleLetterStringsMatch_True()
        {
            string wordToFind = "w";
            string StringToSearch = "w";

            RepeatCounter newRepeatCounter = new RepeatCounter(wordToFind, StringToSearch);

            bool doStringsMatch = newRepeatCounter.CompareWordToFindWithWordFound(StringToSearch);

            Assert.AreEqual(true, doStringsMatch);
        }

        [TestMethod]
        public void CompareWordToFindWithWordFound_ConfirmThatSingleCharacterStringsMatchCaseInsensitive_True()
        {
            string wordToFind = "W";
            string stringToSearch = "w";

            RepeatCounter newRepeatCounter = new RepeatCounter(wordToFind, stringToSearch);

            bool doStringsMatch = newRepeatCounter.CompareWordToFindWithWordFound(stringToSearch);

            Assert.AreEqual(true, doStringsMatch);
        }

        [TestMethod]
        public void CompareWordToFindWithWordFound_ConfirmThatMultipleCharacterStringsMatchCaseInsensitive_True()
        {
            string wordToFind = "windy";
            string stringToSearch = "Windy";

            RepeatCounter newRepeatCounter = new RepeatCounter(wordToFind, stringToSearch);

            bool doStringsMatch = newRepeatCounter.CompareWordToFindWithWordFound(stringToSearch);

            Assert.AreEqual(true, doStringsMatch);
        }

        [TestMethod]
        public void CompareWordToFindWithWordFound_ConfirmThatPunctuationIsIgnored_True()
        {
            string wordToFind = "windy";
            string stringToSearch = "Windy.";

            RepeatCounter newRepeatCounter = new RepeatCounter(wordToFind, stringToSearch);

            bool doStringsMatch = newRepeatCounter.CompareWordToFindWithWordFound(stringToSearch);

            Assert.AreEqual(true, doStringsMatch);
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
