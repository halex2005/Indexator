namespace TextIndexLib
{
  interface IWordIndex
  {
    void AddTextToIndex(string text);
    bool ContainsWord(string word);
  }
}
