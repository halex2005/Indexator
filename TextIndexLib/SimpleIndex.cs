using System;
using System.Collections.Generic;

namespace TextIndexLib
{
  abstract class SimpleIndex : IIndex
  {
    private readonly List<string> indexedWords;

    protected SimpleIndex()
    {
      indexedWords = new List<string>();
    }

    public bool Contains(string text)
    {
      return indexedWords?.Contains(text) ?? false;
    }

    public abstract void AddToIndex(string text);
  }
}
