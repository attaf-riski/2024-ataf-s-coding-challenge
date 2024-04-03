namespace Solution
{
  public static class Program
  {
    public static string RepeatStr(int n, string s)
    {
      string buffer = "";
      for(int i=0;i<n;i++){
        buffer += s;
      }
      return buffer;
    }
  }
}