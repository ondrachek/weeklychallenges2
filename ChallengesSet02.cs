﻿using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length == 0)
                return false;
        }

        public bool IsNumberEven(int number)
        {
            if (number == 0)
                return true;
        }

        public bool IsNumberOdd(int num)
        {
            if ((num % 2) == 0)
                return num % 2 == 1;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            return numbers.Min() + numbers.Max();



        }

        public int GetLengthOfShortestString(string str1, string str2)

            if(numbers == null || numbers.Count() == 0)

            {
            return 0;
            }
            return numbers.Min() + numbers.Max();
        
           
        
         
        
    
   
        


        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public int SumEvens(int[] numbers)

            
        if (numbers == null)

        {
           return 0; 
        }
            var evenSum = 0;
        for (int i = 0; i<numbers.Length; i++)

            if (numbers[i] % 2 == 0)
            {
            evenSum += numbers[i];
            }

        public bool IsSumOdd(List<int> numbers)
        if (numbers == null)
        {
            return false;
        }
         return (numbers.Sum() % 2 != 0);

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
    {
        else
        {
            return number / 2;
        }
    }
        }
    }
}
