using System;
using System.Text;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Counter
  {
    private string _wordToFind;
    private string _stringToSearch;
    private int _matchCount;

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

    public int Get_matchCount()
    {
      return _matchCount;
    }

    public void Set_matchCount(int count)
    {
      _matchCount = count;
    }

    public string RemovePunctuation(string wordToCheck)
    {
      StringBuilder newString = new StringBuilder();
        foreach (char character in wordToCheck)
        {
            if (!char.IsPunctuation(character))
                newString.Append(character);
        }
      return newString.ToString();
    }

    public bool _wordToFindMatches(string wordToCompare)
    {
      return _wordToFind.ToLower() == wordToCompare.ToLower();
    }

    public List<string> FindMatchingWords()
    {
      // char[] charsToTrim = {',', '.', '?', '!', ';', ':'};
      string[] arrayOfStringsToSearch = _stringToSearch.Split(' ');
      List<string> allMatches = new List<string> {};

      foreach (string word in arrayOfStringsToSearch)
      {
        string wordToCompare = word;
        if (_wordToFindMatches(wordToCompare))
        {
          allMatches.Add(wordToCompare);
        }
      }

      return allMatches;
    }

    public int CountMatches()
    {
      List<string> matchingWords = this.FindMatchingWords();

        this.Set_matchCount(matchingWords.Count);
        return _matchCount;
    }

  }
}
