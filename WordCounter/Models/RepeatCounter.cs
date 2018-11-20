using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        private string WordToFind;
        private string StringToSearch;
        private char[] CharsToTrim = {',', '.', '?', '!', ';', ':'};
        private List<string> InstancesOfWordToFind = new List<string> {};

        public RepeatCounter(string wordToFind, string stringToSearch)
        {
            WordToFind = wordToFind;
            StringToSearch = stringToSearch;
        }

        public string GetWordToFind()
        {
            return WordToFind;
        }

        public string GetStringToSearch()
        {
            return StringToSearch;
        }

        public bool CompareWordToFindWithWordFound(string checkThisWord)
        {
            checkThisWord = checkThisWord.TrimEnd(CharsToTrim);
            if (String.Compare(WordToFind, checkThisWord, true) == 0)
            {
                return true;
            }
            return false;
        }

        public int CountHowManyTimesTheWordWasFound()
        {
            string[] arrayOfStringsToSearch = StringToSearch.Split(' ');

            foreach (string word in arrayOfStringsToSearch)
            {
                if (this.CompareWordToFindWithWordFound(word))
                {
                    InstancesOfWordToFind.Add(word);
                }
            }
            Console.WriteLine(InstancesOfWordToFind.Count);
            return InstancesOfWordToFind.Count;
        }

    }
}
