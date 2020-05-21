using System;
using System.Collections.Generic;

namespace Algorithm.Utils
{
    public static class DataCreating
    {
        public static Random Rand = new Random();

        public static List<int> CreateRandomInts(int length, int maxValue = int.MaxValue)
        {
            var ints = new List<int>();

            while (ints.Count < length)
            {
                var firstValue = Rand.Next(((maxValue < 2 ? 2 : maxValue) / 2) - 1);
                var secondValue = Rand.Next(((maxValue < 2 ? 2 : maxValue) / 2) - 1);
                ints.Add(firstValue - secondValue);
            }

            return ints;
        }
    }
}
