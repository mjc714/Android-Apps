using System.Text;
using System;

namespace Core
{
    public static class PhoneTranslator
    {
        // Convert input from user to numbers.
        public static String ToNumber(string raw)
        {
            if (string.IsNullOrEmpty(raw))
            {
                return "";
            }
            else
            {
                raw = raw.ToUpperInvariant();
            }

            var newNumber = new StringBuilder();
            foreach (var c in raw)
            {
                if ("-0123456789".Contains(c))
                {
                    newNumber.Append(c);
                }
                else
                {
                    var result = TranslateToNumber(c);
                    if (result != null)
                    {
                        newNumber.Append(result);
                    }
                }
            }
            return newNumber.ToString();
        }

        // Check if string contains character input, c
        static bool Contains(this string keyString, char c)
        {
            return keyString.IndexOf(c) >= 0;
        }

        // Perform conversion a character to a number
        // matching to a phone keypad.
        static int? TranslateToNumber(char c)
        {
            if ("ABC".Contains(c))
            {
                return 2;
            }
            else if ("DEF".Contains(c))
            {
                return 3;
            }
            else if ("GHI".Contains(c))
            {
                return 4;
            }
            else if ("JKL".Contains(c))
            {
                return 5;
            }
            else if ("MNO".Contains(c))
            {
                return 6;
            }
            else if ("PQRS".Contains(c))
            {
                return 7;
            }
            else if ("TUV".Contains(c))
            {
                return 8;
            }
            else if ("WXYZ".Contains(c))
            {
                return 9;
            }
            return null;
        }
    }
}