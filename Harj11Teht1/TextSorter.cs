using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Harj11Teht1
{
    class TextSorter
    {
        public string ToUpperCase(string word)
        {
            return word.ToUpper();
        }

        public string ToLowerCase(string word)
        {
            return word.ToLower();
        }

        public string ToTitle(string word)
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            TextInfo textInfo = culture.TextInfo;

            return textInfo.ToTitleCase(word);
        }

        public string Reverse(string word)
        {
            char[] wordArray = word.ToCharArray();
            Array.Reverse(wordArray);
            return new string(wordArray);
        }
    }
}