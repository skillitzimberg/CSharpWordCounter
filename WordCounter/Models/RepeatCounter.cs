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
  }
}
