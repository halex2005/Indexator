namespace TextIndexLib
{
  class SubstringIndex : SimpleIndex
  {
    public static SubstringIndex CreateIndex(string text)
    {
      var substringIndex = new SubstringIndex();
      substringIndex.AddToIndex(text);
      return substringIndex;
    }

    public override void AddToIndex(string text)
    {
      for (var length = 1; length <= text.Length; ++length)
      {
        for (var startIndex = 0; startIndex < text.Length - length + 1; 
          ++startIndex)
        {
          var substring = text.Substring(startIndex, length);
          indexedTokens.Add(substring);
        }
      }
    }
  }
}
