using Algorithm.Utils;
using Algorithms.Library;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using static Algorithm.Utils.Helpers;

namespace Algorithms
{
    public static class Program
    {
        public static async Task Main()
        {
            await Console.Out.WriteLineAsync("Starting Algorithms v1.00!\r\n\r\n");

            await RunThreeSumBruteForceSolveAsync("100_Ints");

            await Console.In.ReadLineAsync();
        }

        private const string ThreeSumBruteForce = "ThreeSumBruteForce";
        private const int ThreeSumBruteForceTargetSum = 0;
        public static async Task RunThreeSumBruteForceSolveAsync(string filePathName)
        {
            var ints = await DataLoading.GetIntArrayFromFileAsync(filePathName);

            await ConsoleLogAsync($"Starting {ThreeSumBruteForce}...");

            var sw = Stopwatch.StartNew();
            var solutionCount = ThreeSum.BruteForceSolve(input: ints, targetSum: ThreeSumBruteForceTargetSum);
            sw.Stop();

            await ConsoleLogAsMicrosecondsAsync($"{ThreeSumBruteForce} found {solutionCount} solutions for target sum {ThreeSumBruteForceTargetSum} in", sw);
        }
    }
}
