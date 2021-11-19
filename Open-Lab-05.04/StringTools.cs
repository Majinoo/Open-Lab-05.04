using System;
using System.Text.RegularExpressions;

namespace Open_Lab_05._04
{
    public class StringTools
    {
        public string RemoveSpecialCharacters(string original)
        {
          return  Regex.Replace(original, @"[^0-9a-zA-Z-_ ]+", "");
        }
    }
}
