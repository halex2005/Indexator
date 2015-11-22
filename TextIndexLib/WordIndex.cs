using System.Collections.Generic;
using System.Text;

namespace TextIndexLib
{
  class WordIndex : SimpleIndex
  {
    public static WordIndex CreateIndex(string text)
    {
      var wordIndex = new WordIndex();
      wordIndex.AddToIndex(text);
      return wordIndex;
    }

    public override void AddToIndex(string text)
    {
      var words = SplitTextIntoWords(text);
      indexedTokens.AddRange(words);
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
