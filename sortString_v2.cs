using System;
using System.Linq;

public static class Kata
{
  public static string Order(string words)
        {
            if (string.IsNullOrEmpty(words)) return words;
            return string.Join(" ", words.Split(' ').OrderBy(s => s.ToList().Find(c => char.IsDigit(c))));
        }
}