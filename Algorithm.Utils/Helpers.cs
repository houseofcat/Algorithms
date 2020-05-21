using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Algorithm.Utils
{
    public static class Helpers
    {
        public static string Time() => $"{DateTime.Now:yyyy/MM/dd hh:mm:ss.fff}";

        public static async Task ConsoleLogAsync(string message)
        {
            await Console
                .Out
                .WriteLineAsync($"{Time()}: {message}.");
        }

        public static async Task ConsoleLogAsSecondsAsync(string message, Stopwatch sw)
        {
            await Console
                .Out
                .WriteLineAsync($"{Time()}: {message} {(sw.ElapsedMilliseconds / 1000.0):0.###} s.");
        }

        public static async Task ConsoleLogAsMillisecondsAsync(string message, Stopwatch sw)
        {
            await Console
                .Out
                .WriteLineAsync($"{Time()}: {message} {sw.ElapsedMilliseconds} ms.");
        }

        public static async Task ConsoleLogAsMicrosecondsAsync(string message, Stopwatch sw)
        {
            await Console
                .Out
                .WriteLineAsync($"{Time()}: {message} {sw.ElapsedMicroseconds()} μs.");
        }

        public static async Task ConsoleLogAsNanosecondsAsync(string message, Stopwatch sw)
        {
            await Console
                .Out
                .WriteLineAsync($"{Time()}: {message} {sw.ElapsedNanoseconds()} ns.");
        }
    }
}
