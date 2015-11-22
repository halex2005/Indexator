using System.Collections.Generic;

namespace TextIndexLib
{
  abstract class SimpleIndex : IIndex
  {
    protected readonly List<string> indexedTokens;

    protected SimpleIndex()
    {
      indexedTokens = new List<string>();
    }

    public bool Contains(string text)
    {
      return indexedTokens?.Contains(text) ?? false;
    }

    public abstract void AddToIndex(string text);
  }
}
