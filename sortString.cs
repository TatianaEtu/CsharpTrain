using System;

public static class Kata
{
  public static string Order(string text)
  {
    
    try
    {
      string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
      string[] result = new string[words.Length];
      for ( int i = 1; i<10; i++)
      {    
        foreach (string word in words)
        {
        
          if ( word.Contains(Convert.ToString(i)) )
          {
            result[i-1] = word;
          }
        }
      }
      return Convert.ToString( String.Join(" ", result) );
    }    
    catch
    {
      return "";
    }
    
  }
}