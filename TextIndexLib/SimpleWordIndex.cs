using System.Collections.Generic;
using System.Text;

namespace TextIndexLib
{
  public class SimpleWordIndex : IWordIndex
  {
    private readonly List<string> indexedWords;

    protected SimpleWordIndex()
    {
      indexedWords = new List<string>();
    }

    public static SimpleWordIndex CreateIndex(string text = "")
    {
      var textIndex = new SimpleWordIndex();
      if (!string.IsNullOrEmpty(text))
        textIndex.AddTextToIndex(text);
      return textIndex;
    }

    public void AddTextToIndex(string text)
    {
      var words = SplitTextIntoWords(text);
      indexedWords.AddRange(words);
    }

    public bool ContainsWord(string word)
    {
      return indexedWords.Contains(word);
    }

    private IEnumerable<string> SplitTextIntoWords(string text)
    {
      var allWords = new List<string>();
      var currentWord = new StringBuilder();

      foreach (var ch in text)
      {
        if (char.IsLetter(ch))
          currentWord.Append(ch);
        else if (currentWord.Length > 0)
        {
          allWords.Add(currentWord.ToString());
          currentWord.Clear();
        }
      }
      if (currentWord.Length > 0)
        allWords.Add(currentWord.ToString());

      return allWords;
    }
  }
}
