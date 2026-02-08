using System;
using System.Security;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                
                if (number % 2 == 0)
                {
                    sum+=number;
                }
                else
                {
                    sum -= number;
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int LengthShortestString;
            if (str1.Length < str2.Length)
            {
                LengthShortestString = str1.Length;
                
            }
            else
            {
                LengthShortestString = str2.Length;
            }
            if (LengthShortestString >  str3.Length)
            {
                LengthShortestString = str3.Length;
            }
            if (LengthShortestString >  str4.Length)
            {
                LengthShortestString = str4.Length;
            }

            return LengthShortestString;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] numbers = new int[]{number1, number2, number3, number4};
            int SmallestNumber = numbers[0];
            foreach (var number in numbers)
            {
                if (SmallestNumber > number)
                {
                    SmallestNumber = number;
                }
            }
            return SmallestNumber;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }
        

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            int[] sideLengths = new int[]{sideLength1, sideLength2, sideLength3};
            int SumSideLengths = sideLength1 + sideLength2 + sideLength3;
            for (int i = 0; i < sideLengths.Length; i++)
            {
                if (sideLengths[i] >= SumSideLengths - sideLengths[i])
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsStringANumber(string input)
        {
            double isANumber = 0;
            try
            {
                isANumber = double.Parse(input);
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int count = 0;
            foreach (var obj in objs)
            {
                if (obj == null)
                {
                    count++;
                }
            }
            return (double)(count)/(double)objs.Length>0.5;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int sum = 0;
            int count = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    count++;
                    sum += number;
                }
            }

            if (count == 0)
            {
                return 0;
            }
            return (double)(sum)/(double)(count);
        }

        public int Factorial(int number)
        {
            if (number <0)
            {
                throw new ArgumentOutOfRangeException();
            }
            int fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
