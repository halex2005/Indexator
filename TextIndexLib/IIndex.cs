namespace TextIndexLib
{
  interface IIndex
  {
    void AddToIndex(string text);
    bool Contains(string text);
  }
}
