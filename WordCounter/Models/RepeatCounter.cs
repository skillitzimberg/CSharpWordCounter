using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string WordToFind;
    private string StringToSearch;

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

    public bool CompareWordToFindWithStringToSearch()
    {
      if (WordToFind == StringToSearch)
      {
        return true;
      }
      return false;
    }

    public bool SearchStringToSearchForWordToFind()
    {
      if (StringToSearch.Contains(WordToFind))
      {
        return true;
      }
      return false;
    }

    public List<string> ReturnMatchingWords()
    {
      char[] charsToTrim = {',', '.', '?', '!', ';', ':'};
      string[] arrayOfStringsToSearch = StringToSearch.Split(' ');
      List<string> allMatches = new List<string> {};

      foreach (string word in arrayOfStringsToSearch)
      {
        string checkThisWord = word.TrimEnd(charsToTrim);
        if (WordToFind == checkThisWord)
        {
          allMatches.Add(checkThisWord);
        }
      }
      return allMatches;
    }

    public int CountHowManyTimesTheWordWasFound()
    {
      List<string> matchingWords = this.ReturnMatchingWords();
      return matchingWords.Count;
    }

  }
}
