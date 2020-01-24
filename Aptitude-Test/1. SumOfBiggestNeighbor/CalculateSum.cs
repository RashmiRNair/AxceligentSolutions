using System;
using System.Collections.Generic;

namespace SumOfBiggestNumber
{

    /// <summary>
    /// Time complexity of the algorithm in O(n)
    /// </summary>
    public class CalculateSum
    {
        public int Challenge(int [] input)
        {
            Dictionary<int, int> repeatingNumbers = new Dictionary<int, int>();
            int maxRepetations = 0;
            bool isAllZeros = true;
            int biggestSumOfNeighbors = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != 0)
                    isAllZeros = false;

                if (repeatingNumbers.ContainsKey(input[i]))
                    repeatingNumbers[input[i]] += 1;
                else
                    repeatingNumbers.Add(input[i], 1);


                if (maxRepetations < repeatingNumbers[input[i]])
                    maxRepetations = repeatingNumbers[input[i]];
            }

            if (isAllZeros) return biggestSumOfNeighbors;
            
            for (int i = 0, j=0; i < input.Length; i++)
            {
                if (repeatingNumbers[input[i]]>=maxRepetations-1)
                {                 
                    if(i>j)
                    {
                        if (input[i] + input[j] > biggestSumOfNeighbors)
                        {
                            biggestSumOfNeighbors = input[i] + input[j];
                            j = i;
                        }
                    }
                }
            }

            return biggestSumOfNeighbors;
        }
    }
}
