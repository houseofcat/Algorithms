﻿using static Algorithm.Utils.Helpers;

namespace Algorithm.Library
{
    public static class SelectionSort
    {
        // Complexity O(n^2)
        public static void Sort(int[] input)
        {
            for (int partitionIndex = input.Length - 1; partitionIndex > 0; partitionIndex--)
            {
                var largestIndex = 0;
                for (int i = 1; i <= partitionIndex; i++)
                {
                    if (input[i] > input[largestIndex])
                    {
                        largestIndex = i;
                    }
                }

                Swap(input, largestIndex, partitionIndex);
            }
        }
    }
}
