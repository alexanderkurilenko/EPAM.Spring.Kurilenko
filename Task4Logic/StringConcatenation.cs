using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task4Logic
{
    public static class StringConcatenation
    {
        /// <summary>
        /// Remove duplicate chars
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string RemoveDuplicateChars(string key)
        {
            if (key == null)
            {
                throw new NullReferenceException();
            }

            string table = String.Empty;
            string result = String.Empty;

            foreach (char value in key)
            {
                if (table.IndexOf(value) == -1)
                {
                    table += value;
                    result += value;
                }
            }
            return result;
        }

        /// <summary>
        /// Sorting according alphabet
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string Alphabetize(string s)
        {
            if (s == null)
            {
                throw new NullReferenceException();
            }

            char[] strArr = s.ToCharArray();
            Array.Sort(strArr);

            return new string(strArr);
        }

        /// <summary>
        /// Concatenation two strings
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public static string Concate(string str1, string str2)
        {
            Regex rgx = new Regex(@"^[a-z]+");

            if (str1 == null || str2 == null)
            {
                throw new NullReferenceException();
            }
            if (rgx.IsMatch(str1) && rgx.IsMatch(str2) == false)
            {
                throw new FormatException();
            }

            string result = RemoveDuplicateChars(str1 + str2) ;

            return Alphabetize(result);

        }
    }
}
