using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                if (!vals[i])
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum % 2 == 1;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool hasUp = false;
            bool hasLow = false;
            bool hasNum = false;
            char p;
            for (int i = 0; i < password.Length; i++)
            {
                p = password[i];
                if (char.IsUpper(p))
                {
                    hasUp = true;
                }
                if (char.IsLower(p))
                {
                    hasLow = true;
                }

                if (char.IsNumber(p))
                {
                    hasNum = true;
                }

            }
            return hasUp && hasLow && hasNum;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return  nums[nums.Length - 1]-nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] oddsBelow100 = new int[50];
            for (int i = 0; i < oddsBelow100.Length; i++)
            {
                oddsBelow100[i] = i*2 + 1;
            }
            return oddsBelow100;
        }

        public string[] ChangeAllElementsToUppercase(string[] words)
        {
            string[] newWords = new string[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                newWords[i] = words[i].ToUpper();
            }
            return newWords;
        }
    }
}
