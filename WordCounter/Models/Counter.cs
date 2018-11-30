using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Counter
  {
    private string _wordToFind;
    private string _stringToSearch;

    public Counter(string wordToFind, string stringToSearch)
    {
      _wordToFind = wordToFind;
      _stringToSearch = stringToSearch;
    }

    public string Get_wordToFind()
    {
      return _wordToFind;
    }

    public string Get_stringToSearch()
    {
      return _stringToSearch;
    }

    public bool _wordToFindMatches(string wordToCompare)
    {
      return _wordToFind == wordToCompare.ToLower();
    }

    public List<string> FindMatchingWords()
    {
      char[] charsToTrim = {',', '.', '?', '!', ';', ':'};
      string[] arrayOfStringsToSearch = _stringToSearch.Split(' ');
      List<string> allMatches = new List<string> {};

      foreach (string word in arrayOfStringsToSearch)
      {
        string wordToCompare = word.TrimEnd(charsToTrim);
        if (_wordToFindMatches(wordToCompare))
        {
          allMatches.Add(wordToCompare);
        }
      }
      return allMatches;
    }

    public int CountHowManyTimesTheWordWasFound()
    {
      List<string> matchingWords = this.FindMatchingWords();
      return matchingWords.Count;
    }

  }
}
