using System;
using System.Globalization;

namespace OP_L7
{
	public class StrProc
	{
		public static int LettersCount(string str)
		{
			int count=0;
			for (int i = 0; i < str.Length; i++)
			{
				if (Char.IsLetter(str[i]))
				{
					count++;
				}
			}
			return count;
		}

		public static double AverageWordLen(string str)
		{
            string[] WordArray = str.Split(new char[] { ' ' });
			return (double)LettersCount(str) / WordArray.Length;
        }

		public static string WordChange(string str, string word1, string word2)
		{
			string res="";
            string[] WordArray = str.Split(new char[] { ' ' });
			for (int i = 0; i < WordArray.Length; i++)
			{
				string temp = WordArray[i].Trim(new char[] { ',', '.', '!', '-', '?' });
				if (temp.ToLower() == word1)
				{
					WordArray[i] = WordArray[i].ToLower().Replace(word1, word2);
				}
            }
			for (int i = 0; i < WordArray.Length; i++)
			{
				res += WordArray[i] + " ";
			}
			return res;
        }

		public static int SubstrCount(string str, string sub)
		{
			int count = 0;
			str = str.ToLower();
			sub = sub.ToLower();
			for (int i = 0; i < str.Length-sub.Length; i++)
			{
				if (str.Substring(i, sub.Length) == sub)
				{
					count++;
				}
			}
			return count;
		}

		public static bool IsPalindrome(string str)
		{
			str = str.ToLower();
			string str1 = "";
			string str2 = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsLetter(str[i]))
                {
					str1 += str[i];
                }
            }
			for (int i = str1.Length-1; i > -1; i--)
			{
				str2 += str1[i];
			}
            if (str1 == str2)
			{
				return true;
			}
			else
			{
				return false;
			}
        }

		public static bool CheckDate(string str)
		{
            DateTimeFormatInfo ruformat = CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat;
            DateTime result;
			return DateTime.TryParse(str, ruformat, out result);
			
        }
    }
}

